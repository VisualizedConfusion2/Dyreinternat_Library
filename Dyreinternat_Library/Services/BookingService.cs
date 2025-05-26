using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dyreinternat_Library.Interfaces;
using Dyreinternat_Library.Models;

namespace Dyreinternat_Library.Services
{
    public class BookingService
    {
        private IBookingRepo _bookingRepo; // Interface for Booking Repository
        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo; // Constructor for Booking Service, which takes an IBookingRepo as a parameter
        }

        public List<Booking> GetAll() // Returns the list of all bookings
        {
            return _bookingRepo.GetAll(); // This method retrieves all bookings from the repository
        }

        public void Add(Booking booking) // Adds a booking to the repository
        {
            _bookingRepo.Add(booking); // This method adds a new booking to the repository
        }


        public Booking GetByID(int id) // Gets a specific booking from the ID
        {
            return _bookingRepo.GetByID(id); // This method retrieves a booking by its ID from the repository
        }

    }
}
