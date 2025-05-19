using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IDoctorVisitRepo
    {
        List<DoctorVisit> GetAll(); // List for all DoctorVisits

        void Add(DoctorVisit doctorVisit); // Adds a doctor visit to the repository

        DoctorVisit GetByID(int id); // Gets a specific doctor visit by ID
    }
}
