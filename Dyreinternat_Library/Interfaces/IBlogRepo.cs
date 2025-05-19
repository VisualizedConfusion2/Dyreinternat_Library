using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IBlogRepo
    {
        public List<Blog> GetAll(); // List for all Blogs

        public void Add(Blog blog); // Adds a blog to the repository

        public Blog GetByID(int id); // Gets a specific blog from the ID
    }
}
