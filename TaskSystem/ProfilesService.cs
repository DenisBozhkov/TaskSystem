using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Models;

namespace TaskSystem
{
    public class ProfilesService
    {
        private readonly List<ProfileModel> profiles = [];
        public ProfilesService() 
        {
            profiles.Add(new() { UserName = "test123", Password = HashPassword("test123"), Email = "test123@test.com" });
            profiles.Add(new() { UserName = "admin", Password = HashPassword("admin"), Email = "admin@test.com" });
        }
        public void CreateProfile(ProfileModel profile)
        {
            if (GetProfile(profile.UserName) != null)
                throw new InvalidDataException("The username is already is used by another profile!");
            profiles.Add(profile);
        }
        public ProfileModel? GetProfile(string userName)
        {
            return profiles.Find(x => x.UserName == userName);
        }
        public bool CheckProfilePassword(ProfileModel profile)
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
