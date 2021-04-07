using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Dashboard.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Id { get; set; }
        public string Occupation { get; set; }
        public int Impressions { get; set; }
        public int Conversions { get; set; }
        public double Revenue { get; set; }

        // User Profiles Data can come either from JSON (file or CDN) or database
        public static List<UserProfile> GetUserProfiles(string jsonFilePath = "", string cdnPathOfJson = "", string connectionString = "")
        {
            List<UserProfile> userprofiles = new List<UserProfile>();
            UserProfile userprofile;
            if (File.Exists(jsonFilePath))
            {
                // deserialize JSON directly from a file
                string[] lines = File.ReadAllLines(@"App_Data\users.json");
                foreach (string line in lines)
                {
                    userprofile = (UserProfile)JsonConvert.DeserializeObject(line);
                    userprofiles.Add(userprofile);
                    userprofile = null;
                }
                return userprofiles;
            }
            else if (!string.IsNullOrWhiteSpace(cdnPathOfJson))
            {
                return null;
            }
            else if (!string.IsNullOrWhiteSpace(connectionString))
            {
                return null;
            }
            return null;
        }

    }
}