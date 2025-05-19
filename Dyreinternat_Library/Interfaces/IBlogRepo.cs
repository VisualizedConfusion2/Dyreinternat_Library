using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IBlogRepo
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime DateTime { get; set; }
        string Image { get; set; }
        string Author { get; set; }
        int BlogID { get; set; }
    }
}
