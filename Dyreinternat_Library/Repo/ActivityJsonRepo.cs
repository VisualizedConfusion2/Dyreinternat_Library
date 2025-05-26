using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Dyreinternat_Library.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace Dyreinternat_Library.Repo
{
    public class ActivityJsonRepo : IActivityRepo
    {
        private List<Activity> _activities = new List<Activity>(); // List of all Activities
        private string _path; // Filepath for the json file

        public ActivityJsonRepo(string path)
        {
            _path = path;
            LoadFile(_path);
        }

        private void LoadFile(string path) // Method to get the data from the json file
        {
            string file = path + "activities.json";
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                var activities = JsonSerializer.Deserialize<List<Activity>>(json);
                if (activities != null)
                    _activities = activities;
            }
        }

        private void SaveFile(string path) // Method to save the data to the json file
        {
            File.WriteAllText(path + "activities.json", JsonSerializer.Serialize(_activities, new JsonSerializerOptions { WriteIndented = true }));
        }

        public void Add(Activity activity) // Adds an activity to the repository
        {
            _activities.Add(activity);
            SaveFile(_path);
        }

        public List<Activity> GetAll() // Returns the list of all activities
        {
            return _activities;
        }

        public Activity GetByID(int id) // Returns an activity from a specific id
        {
            foreach (Activity activity in _activities)
            {
                if (id == activity.ActivityID)
                {
                    return activity;
                }
            }
            return null;
        }
        public void UpdateActivity(Activity updatedActivity)
        {
            Activity existing = _activities.FirstOrDefault(a => a.ActivityID == updatedActivity.ActivityID);
            if (existing != null)
            {
                existing.Title = updatedActivity.Title;
                existing.Description = updatedActivity.Description;
                existing.DateTime = updatedActivity.DateTime;
                existing.NumberOfPerticipants = updatedActivity.NumberOfPerticipants;
                existing.Author = updatedActivity.Author;
                existing.ActivityID = updatedActivity.ActivityID;
            }
            SaveFile(_path);

        }
    }
}
