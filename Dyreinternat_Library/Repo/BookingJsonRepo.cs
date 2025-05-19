using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Repo
{

        public class BookingJsonRepo
        {
            private List<Booking> _bookings = new List<Booking>(); // List of all Activities
            private string _path; // Filepath for the json file

            public BookingJsonRepo(string path)
            {
                _path = path;
                LoadFile(_path);
            }

            private void LoadFile(string path) // Method to get the data from the json file
            {
                string file = path + "bookings.json";
                if (File.Exists(file))
                {
                    string json = File.ReadAllText(file);
                    var bookings = JsonSerializer.Deserialize<List<Booking>>(json);
                    if (bookings != null)
                        _bookings = bookings;
                }
            }

            private void SaveFile(string path) // Method to save the data to the json file
            {
                File.WriteAllText(path + "bookings.json", JsonSerializer.Serialize(_bookings, new JsonSerializerOptions { WriteIndented = true }));
            }

            public void Add(Booking booking) // Adds an activity to the repository
            {
                _bookings.Add(booking);
                SaveFile(_path);
            }

            public List<Booking> GetAll() // Returns the list of all activities
            {
                return _bookings;
            }

            public Booking GetByID(int id) // Returns an activity from a specific id
            {
                foreach (Booking booking in _bookings)
                {
                    if (id == booking.BookingID)
                    {
                        return booking;
                    }
                }
                return null;
            }
        }
}
