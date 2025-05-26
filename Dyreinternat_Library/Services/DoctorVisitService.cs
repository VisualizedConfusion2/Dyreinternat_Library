using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class DoctorVisitService
    {
        private IDoctorVisitRepo _doctorVisitRepo; // Interface for DoctorVisit Repository
        public DoctorVisitService(IDoctorVisitRepo doctorVisitRepo) // Constructor for DoctorVisit Service, which takes an IDoctorVisitRepo as a parameter
        {
            _doctorVisitRepo = doctorVisitRepo; // Initializes the doctor visit repository
        }

        public List<DoctorVisit> GetAll() // Returns the list of all doctor visits
        {
            return _doctorVisitRepo.GetAll(); // This method retrieves all doctor visits from the repository
        }

        public void Add(DoctorVisit DoctorVisit) // Adds a doctor visit to the repository
        {
            _doctorVisitRepo.Add(DoctorVisit); // This method adds a new doctor visit to the repository
        }


        public DoctorVisit GetByID(int createdByEmployeeID) // Gets a specific doctor visit from the ID of the employee who created it
        {
            return _doctorVisitRepo.GetByID(createdByEmployeeID); // This method retrieves a doctor visit by its ID from the repository
        }
    }
}
