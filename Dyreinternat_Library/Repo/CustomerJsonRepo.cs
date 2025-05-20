using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Dyreinternat_Library.Interfaces;

namespace Dyreinternat_Library.Repo
{
    public class CustomerJsonRepo : ICustomerRepo
    {
        private List<Customer> _customers = new List<Customer>(); // List of all Activities
        private string _path; // Filepath for the json file

        public CustomerJsonRepo(string path)
        {
            _path = path;
            LoadFile(_path);
        }

        private void LoadFile(string path) // Method to get the data from the json file
        {
            string file = path + "customer.json";
            if (File.Exists(file))
            {
                string json = File.ReadAllText(file);
                var customers = JsonSerializer.Deserialize<List<Customer>>(json);
                if (customers != null)
                    _customers = customers;
            }
        }

        private void SaveFile(string path) // Method to save the data to the json file
        {
            File.WriteAllText(path + "customers.json", JsonSerializer.Serialize(_customers, new JsonSerializerOptions { WriteIndented = true }));
        }

        public void Add(Customer customer) // Adds an activity to the repository
        {
            _customers.Add(customer);
            SaveFile(_path);
        }

        public List<Customer> GetAll() // Returns the list of all activities
        {
            return _customers;
        }

        public Customer GetByID(int id) // Returns an activity from a specific id
        {
            foreach (Customer customer in _customers)
            {
                if (id == customer.CustomerID)
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
