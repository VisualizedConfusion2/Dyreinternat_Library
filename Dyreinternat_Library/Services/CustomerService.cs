using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class CustomerService
    {
        private ICustomerRepo _customerRepo; // Interface for Customer Repository
        public CustomerService(ICustomerRepo customerRepo) // Constructor for Customer Service, which takes an ICustomerRepo as a parameter
        {
            _customerRepo = customerRepo; // Initializes the customer repository
        }

        public List<Customer> GetAll() // Returns the list of all customers
        {
            return _customerRepo.GetAll(); // This method retrieves all customers from the repository
        }

        public void Add(Customer Customer) // Adds a customer to the repository
        {
            _customerRepo.Add(Customer); // This method adds a new customer to the repository
        }


        public Customer GetByID(int customerID) // Gets a specific customer from the ID
        {
            return _customerRepo.GetByID(customerID); // This method retrieves a customer by its ID from the repository
        }
    }
}
