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
        private IEmployeeRepo _employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public List<Employee> GetAll()
        {
            return _employeeRepo.GetAll();
        }

        public void Add(Employee Employee)
        {
            _employeeRepo.Add(Employee);
        }


        public Employee GetByID(int id)
        {
            return _employeeRepo.GetByID(id);
        }
    }
}
