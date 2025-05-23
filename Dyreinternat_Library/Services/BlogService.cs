﻿using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class BlogService
    {
        private IBlogRepo _blogRepo;
        public BlogService(IBlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }

        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }

        public void Add(Blog blog)
        {
            _blogRepo.Add(blog);
        }

        public Blog GetByID(int blogID)
        {
            return _blogRepo.GetByID(blogID);
        }

        public void Update(Blog blog)
        {
            _blogRepo.Update(blog);
        }
    }
}
