using Dyreinternat_Library.Interfaces;
using Dyreinternat_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Repo
{
    public class EmployeeJsonRepo:IEmployeeRepo
    {
        private List<Employee> _employee = new List<Employee>(); // List of all Employees
        private string _path; // Filepath for the json file
        public EmployeeJsonRepo(string path)
        {
            _path = path;
            LoadFile(_path);
        }
        private void LoadFile(string path) // Method to get the data from the json file
        {
            string json = File.ReadAllText(path + "employee.json");
            _employee = JsonSerializer.Deserialize<List<Employee>>(json);
        }
        private void SaveFile(string path) // Method to save the date to the json file
        {
            File.WriteAllText(path + "employee.json", JsonSerializer.Serialize(_employee, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void Add(Employee employee) // Adds an employee to the repository
        {
            _employee.Add(employee);
            SaveFile(_path);
        }
        public List<Employee> GetAll() // Returns the list of all employees
        {
            return _employee;
        }

        public Employee GetByID(int employeeID) // Returns an employee from a specific id
        {
            foreach (Employee employee in _employee)
            {
                if (employeeID == employee.EmployeeID)
                {
                    return employee;
                }
            }
            return null;
        }
    }
}
