using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Dyreinternat_Library.Services;
using Dyreinternat_Library.Models;
using Dyreinternat_Library.Interfaces;

namespace Dyreinternat_Library.Repo
{
    public class AnimalJsonRepo: IAnimalRepo
    {
        private List<Animal> _animals = new List<Animal>(); // List of all Animals
        private string _path; // Filepath for the json file
        public AnimalJsonRepo(string path)
        {
            _path = path;
            LoadFile(_path);
        }
        private void LoadFile(string path) // Method to get the data from the json file
        {
            string json = File.ReadAllText(path + "animals.json");
            _animals = JsonSerializer.Deserialize<List<Animal>>(json);
        }
        private void SaveFile(string path) // Method to save the date to the json file
        {
            File.WriteAllText(path + "animals.json", JsonSerializer.Serialize(_animals, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void Add(Animal animal) // Adds an animal to the repository
        {
            _animals.Add(animal);
            SaveFile(_path);
        }
        public List<Animal> GetAll() // Returns the list of all animals
        {
            return _animals;
        }

        public Animal GetByID(int chipNumber) // Returns an animal from a specific id
        {
            foreach (Animal animal in _animals)
            {
                if (chipNumber == animal.ChipNumber)
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
