using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAll(); // List for all Customers

        void Add(Customer customer); // Adds a customer to the repository

        Customer GetByID(int id); // Gets a specific customer from the ID
    }
}
