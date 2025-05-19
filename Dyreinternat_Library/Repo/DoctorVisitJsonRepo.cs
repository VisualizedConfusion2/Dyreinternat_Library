using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Repo
{
    public class DoctorVisitJsonRepo
    {
            private List<DoctorVisit> _doctorVisits = new List<DoctorVisit>(); // List of all Activities
            private string _path; // Filepath for the json file

            public DoctorVisitJsonRepo(string path)
            {
                _path = path;
                LoadFile(_path);
            }

            private void LoadFile(string path) // Method to get the data from the json file
            {
                string file = path + "doctorVisit.json";
                if (File.Exists(file))
                {
                    string json = File.ReadAllText(file);
                    var doctorVisit = JsonSerializer.Deserialize<List<DoctorVisit>>(json);
                    if (doctorVisit != null)
                        _doctorVisits = doctorVisit;
                }
            }

            private void SaveFile(string path) // Method to save the data to the json file
            {
                File.WriteAllText(path + "bookings.json", JsonSerializer.Serialize(_doctorVisits, new JsonSerializerOptions { WriteIndented = true }));
            }

            public void Add(DoctorVisit doctorVisit) // Adds an activity to the repository
            {
                _doctorVisits.Add(doctorVisit);
                SaveFile(_path);
            }

            public List<DoctorVisit> GetAll() // Returns the list of all activities
            {
                return _doctorVisits;
            }

            public DoctorVisit GetByID(int id) // Returns an activity from a specific id
            {
                foreach (DoctorVisit doctorVisit in _doctorVisits)
                {
                    if (id == doctorVisit.CreatedByEmployeeID)
                    {
                        return doctorVisit;
                    }
                }
                return null;
            }
        }

    }


