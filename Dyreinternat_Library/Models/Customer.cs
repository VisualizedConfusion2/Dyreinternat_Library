namespace Dyreinternat_Library
{
    public class Customer
    {
        //Instance Variables
        private string _name;
        private string _email;
        private string _phoneNumber;
        private int _customerID;


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

        public int CustomerID
        {
            get
            {
                return _customerID;
            }
            set => _customerID = value;
        }


        //Constructor
        public Customer(string name, string email, string phoneNumber, int costumerID)
        {
            _name = name;
            _email = email;
            _phoneNumber = phoneNumber;
            _costomerID = costumerID;
            
        }


    }
}
