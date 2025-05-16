using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dyreinternat_Library.Models;

namespace Dyreinternat_Library.Services
{
    public interface IAnimalRepo
    {
        public List<Animal> GetAll(); // List for all Animals

        public void Add(Animal animal); // Adds an animal to the repository

        public Animal GetByID(int id); // Gets a specefic animal from the ID
    }
}
