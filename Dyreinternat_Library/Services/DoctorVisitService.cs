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
        private IDoctorVisitRepo _doctorVisitRepo;
        public DoctorVisitService(IDoctorVisitRepo doctorVisitRepo)
        {
            _doctorVisitRepo = doctorVisitRepo;
        }

        public List<DoctorVisit> GetAll()
        {
            return _doctorVisitRepo.GetAll();
        }

        public void Add(DoctorVisit DoctorVisit)
        {
            _doctorVisitRepo.Add(DoctorVisit);
        }


        public DoctorVisit GetByID(int createdByEmployeeID)
        {
            return _doctorVisitRepo.GetByID(createdByEmployeeID);
        }
    }
}
