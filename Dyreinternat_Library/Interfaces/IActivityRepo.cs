using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IActivityRepo
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateTime { get; set; }
        int NumberOfPerticipants { get; set; }
        string Author { get; set; }
        int ActivityID { get; set; }
    }
}
