using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IEmployeeRepo
    {
        string Name { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        int EmployeeID { get; set; }
        Enum Role { get; set; }
    }
}
