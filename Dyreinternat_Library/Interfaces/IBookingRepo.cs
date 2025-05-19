using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IBookingRepo
    {
        List<Booking> GetAll(); // List for all Bookings

        void Add(Booking booking); // Adds a booking to the repository

        Booking GetByID(int id); // Gets a specific booking from the ID
    }
}
