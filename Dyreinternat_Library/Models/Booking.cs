namespace Dyreinternat_Library
{
    public class Booking
    {
        //Instance Variables
        private string _phoneNumber;
        private int _bookingID;

        //Properties
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set => _phoneNumber = value;
        }

        public int BookingID 
        { 
            get
            {
                return _bookingID;
            }
            set => _bookingID = value; 
        }


        //Constructor
        public Booking(string phoneNumber, int bookingID)
        {
            _phoneNumber = phoneNumber;
            _bookingID = bookingID;
        }

        public Booking()
        {

        }
    }
}
