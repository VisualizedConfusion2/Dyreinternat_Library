namespace Dyreinternat_Library
{
    public class Booking
    {
        //Instance Variables
        private string phoneNumber;
        private int bookingID;

        //Properties
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set => phoneNumber = value;
        }

        public int BookingID 
        { 
            get
            {
                return bookingID;
            }
            set => bookingID = value; 
        }


        //Constructor
        public Booking(string phoneNumber, int bookingID)
        {
            PhoneNumber = phoneNumber;
            BookingID = bookingID;
        }
    }
}
