using Microsoft.Data.SqlClient;
using TaskSystem.Models;

namespace TaskSystem
{
    public static class GlobalService
    {
        public static ProfileModel? LoggedInProfile { get; set; }
        public static string DbConnectionString { get; private set; }
        static GlobalService()
        {
            SqlConnection conn = new("Data Source=(localdb)\\MSSQLLocalDB");
            SqlCommand comm;
            conn.Open();
            try
            {
                comm = conn.CreateCommand();
                comm.CommandText = "USE Tasks";
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                comm = conn.CreateCommand();
                comm.CommandText = "CREATE DATABASE Tasks COLLATE Cyrillic_General_CI_AS";
                comm.ExecuteNonQuery();

                comm = conn.CreateCommand();
                comm.CommandText = "USE Tasks";
                comm.ExecuteNonQuery();

                comm = conn.CreateCommand();
                comm.CommandText = "CREATE TABLE Profiles(" +
                                  "UserName VARCHAR(75) PRIMARY KEY," +
                                  "Password VARBINARY(MAX) NOT NULL," +
                                  "Email VARCHAR(100) NOT NULL)";
                comm.ExecuteNonQuery();

                comm = conn.CreateCommand();
                comm.CommandText = "CREATE TABLE Tasks(" +
                                 "Id INT PRIMARY KEY IDENTITY(1,1)," +
                                 "Title VARCHAR(100) NOT NULL," +
                                 "Description TEXT NOT NULL," +
                                 "Deadline DATE NOT NULL," +
                                 "Priority INT NOT NULL," +
                                 "IsDone BIT DEFAULT 0," +
                                 "CreatedBy VARCHAR(75) REFERENCES Profiles(UserName))";
                comm.ExecuteNonQuery();
            }
            conn.Close();
            DbConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tasks";
        }
    }
}
