namespace Dyreinternat_Library
{
    public class Costomer
    {
        private string _name;
        private string _email;
        private string _phoneNumber;
        private int _costomerID;



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

        public int CostomerID
        {
            get
            {
                return _costomerID;
            }
            set => _costomerID = value;
        }

        public Costomer(string name, string email, string phoneNumber, int costumerID)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            CostomerID = costumerID;
            
        }


    }
}
