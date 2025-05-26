using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class BlogService
    {
        private IBlogRepo _blogRepo; // Interface for the Blog repository
        public BlogService(IBlogRepo blogRepo)
        {
            _blogRepo = blogRepo; // Constructor for the BlogService, which takes an IBlogRepo as a parameter
        }

        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll(); // Returns the list of all blogs
        }

        public void Add(Blog blog) // Adds a blog to the repository
        {
            _blogRepo.Add(blog);
        }

        public Blog GetByID(int blogID) // Gets a specific blog from the ID
        {
            return _blogRepo.GetByID(blogID);
        }

        public void Update(Blog blog) // Updates specific information in blogs
        {
            _blogRepo.Update(blog);
        }
    }
}
