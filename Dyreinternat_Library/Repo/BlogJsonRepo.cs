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
    public class BlogJsonRepo : IBlogRepo
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
            string file = path + "blogs.json";
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
            File.WriteAllText(path + "blogs.json", JsonSerializer.Serialize(_blogs, new JsonSerializerOptions { WriteIndented = true }));
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
        public void Update(Blog updatedBlog)
        {
        Blog existing = _blogs.FirstOrDefault(b => b.BlogID == updatedBlog.BlogID);
        if (existing != null)
        {
            existing.Title = updatedBlog.Title;
            existing.Description = updatedBlog.Description;
            existing.DateTime = updatedBlog.DateTime;
            existing.Author = updatedBlog.Author;
            existing.Image = updatedBlog.Image;
        }
        SaveFile(_path);

        }


    }
}
