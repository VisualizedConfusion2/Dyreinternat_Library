using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Repo
{
    public class BlogJsonRepo
    {
        private List<Blog> _blogs = new List<Blog>(); // List of all Activities
        private string _path; // Filepath for the json file

        public BlogJsonRepo(string path)
        {
            _path = path;
            LoadFile(_path);
        }

        private void LoadFile(string path) // Method to get the data from the json file
        {
            string file = path + "blog.json";
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                var blogs = JsonSerializer.Deserialize<List<Blog>>(json);
                if (blogs != null)
                    _blogs = blogs;
            }
        }

        private void SaveFile(string path) // Method to save the data to the json file
        {
            File.WriteAllText(path + "activities.json", JsonSerializer.Serialize(_blogs, new JsonSerializerOptions { WriteIndented = true }));
        }

        public void Add(Blog blog) // Adds an activity to the repository
        {
            _blogs.Add(blog);
            SaveFile(_path);
        }

        public List<Blog> GetAll() // Returns the list of all activities
        {
            return _blogs;
        }

        public Blog GetByID(int id) // Returns an activity from a specific id
        {
            foreach (Blog blog in _blogs)
            {
                if (id == blog.BlogID)
                {
                    return blog;
                }
            }
            return null;
        }

    }
}
