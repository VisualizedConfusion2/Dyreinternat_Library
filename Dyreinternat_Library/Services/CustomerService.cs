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
        private ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public List<Customer> GetAll()
        {
            return _customerRepo.GetAll();
        }

        public void Add(Customer Customer)
        {
            _customerRepo.Add(Customer);
        }


        public Customer GetByID(int customerID)
        {
            return _customerRepo.GetByID(customerID);
        }
    }
}
