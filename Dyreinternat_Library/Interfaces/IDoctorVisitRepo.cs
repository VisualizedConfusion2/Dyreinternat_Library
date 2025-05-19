using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IDoctorVisitRepo
    {
        DateTime Datetime { get; set; }
        string Description { get; set; }
        int AnimalID { get; set; }
        int CreatedByEmployeeID { get; set; }
    }
}
