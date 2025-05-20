using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dyreinternat_Library.Interfaces;
using Dyreinternat_Library.Models;


namespace Dyreinternat_Library.Services
{
    public class AnimalService
    {
        private IAnimalRepo _animalRepo;
        public AnimalService(IAnimalRepo animalRepo)
        {
            _animalRepo = animalRepo;
        }

        public List<Animal> GetAll()
        {
            return _animalRepo.GetAll();
        }

        public void Add(Animal animal)
        {
            _animalRepo.Add(animal);
        }


        public Animal GetByID(int chipNumber)
        {
            return _animalRepo.GetByID(chipNumber);
        }
    }
}
