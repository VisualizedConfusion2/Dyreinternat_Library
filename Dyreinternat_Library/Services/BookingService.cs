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
        private IBookingRepo _bookingRepo;
        public BookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        public List<Booking> GetAll()
        {
            return _bookingRepo.GetAll();
        }

        public void Add(Booking booking)
        {
            _bookingRepo.Add(booking);
        }


        public Booking GetByID(int id)
        {
            return _bookingRepo.GetByID(id);
        }

    }
}
