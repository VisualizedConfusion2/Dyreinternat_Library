using Dyreinternat_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyreinternat_Library.Services
{
    public class ActivityService
    {

        private IActivityRepo _activityRepo;
        public ActivityService(IActivityRepo activityRepo)
        {
            _activityRepo = activityRepo;
        }

        public List<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }

        public void Add(Activity Activity)
        {
            _activityRepo.Add(Activity);
        }


        public Activity GetByID(int activityID)
        {
            return _activityRepo.GetByID(activityID);
        }
    }
}

