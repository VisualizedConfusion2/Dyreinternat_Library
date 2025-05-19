using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Interfaces
{
    public interface IActivityRepo
    {
        List<Activity> GetAll(); // List for all Activities

        void Add(Activity activity); // Adds an activity to the repository

        Activity GetByID(int id); // Gets a specific activity from the ID
    }
}
