using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IEmployeeRepo
    {
        List<Employee> GetAll(); // List for all Employees

        void Add(Employee employee); // Adds an employee to the repository

        Employee GetByID(int id); // Gets a specific employee from the ID
    }
}
