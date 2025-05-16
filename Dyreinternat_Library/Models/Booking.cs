namespace Dyreinternat_Library
{
    public class Booking
    {
        private string phoneNumber;
        private int bookingID;


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

        public Booking(string phoneNumber, int bookingID)
        {
            PhoneNumber = phoneNumber;
            BookingID = bookingID;
        }
    }
}
