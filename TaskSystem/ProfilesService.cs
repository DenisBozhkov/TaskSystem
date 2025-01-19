using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using TaskSystem.Models;

namespace TaskSystem
{
    public static class ProfilesService
    {
        public static void CreateProfile(ProfileModel profile)
        {
            if (GetProfile(profile.UserName) != null)
                throw new InvalidDataException("The username is already is used by another profile!");
            SqlConnection con = new(GlobalService.DbConnectionString);
            con.Open();
            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO Profiles VALUES(@UserName,@Password,@Email)";
            comm.Parameters.AddWithValue("@UserName", profile.UserName);
            comm.Parameters.AddWithValue("@Password", profile.Password);
            comm.Parameters.AddWithValue("@Email", profile.Email);
            comm.ExecuteNonQuery();
            con.Close();
        }
        public static ProfileModel? GetProfile(string userName)
        {
            ProfileModel? profile = null;
            SqlConnection con =new(GlobalService.DbConnectionString);
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT * FROM Profiles WHERE UserName=@UserName";
            command.Parameters.AddWithValue("@UserName", userName);
            var reader = command.ExecuteReader();
            if (reader.Read())
                profile = new()
                {
                    UserName = userName,
                    Password = (byte[])reader["Password"],
                    Email = (string)reader["Email"]
                };
            con.Close();
            return profile;
        }
        public static bool CheckProfilePassword(ProfileModel profile)
        {
            ProfileModel dbProfile = GetProfile(profile.UserName) ?? throw new InvalidDataException("There is no profile with the given username!");
            return profile.Password.SequenceEqual(dbProfile.Password);
        }
        public static byte[] HashPassword(string password)
        {
            return SHA512.HashData(new UTF8Encoding().GetBytes(password));
        }
    }
}
