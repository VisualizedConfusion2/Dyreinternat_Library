﻿namespace Dyreinternat_Library
{
    public class Employee
    {
        //Instance Variables
        private string _name;
        private string _email;
        private string _phoneNumber;
        private int _employeeID;
        private Role _role;

        public enum Role
        {
            Manager,
            Doctor,         
            Administration
        }


        //Properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string PhoneNumber
        {
              get
            {
                return _phoneNumber;
            }
            set => _phoneNumber = value;
        }

        public int EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set => _employeeID = value;
        }

        public Role EmployeeRole
        {
            get => _role;
            set => _role = value;
        }

        //Constructor
        public Employee(string name, string email, string phoneNumber, int employeeID, Role role) 
        { 
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
            _employeeID = employeeID;
            _role = role;
        
        
        }

        public Employee()
        {

        }
    }
}
