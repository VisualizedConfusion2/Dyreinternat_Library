using Dyreinternat_Library.Interfaces;
using Dyreinternat_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class EmployeeService
    {
        private IEmployeeRepo _employeeRepo; // Interface for Employee Repository
        public EmployeeService(IEmployeeRepo employeeRepo) // Constructor for Employee Service, which takes an IEmployeeRepo as a parameter
        {
            _employeeRepo = employeeRepo; // Initializes the employee repository
        }

        public List<Employee> GetAll() // Returns the list of all employees
        {
            return _employeeRepo.GetAll(); // This method retrieves all employees from the repository
        }

        public void Add(Employee Employee) // Adds an employee to the repository
        {
            _employeeRepo.Add(Employee); // This method adds a new employee to the repository
        }


        public Employee GetByID(int employeeID) // Gets a specific employee from the ID
        {
            return _employeeRepo.GetByID(employeeID); // This method retrieves an employee by its ID from the repository
        }
    }
}
