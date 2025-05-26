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

        public void Add(Activity activity)
        {
            _activityRepo.Add(activity);
        }


        public Activity GetByID(int activityID)
        {
            return _activityRepo.GetByID(activityID);
        }

        public void UpdateActivity(Activity activity)
        {
            _activityRepo.UpdateActivity(activity);
        }
        public bool RegisterCustomerToActivity(int activityId, int customerId)
        {
            var activity = _activityRepo.GetByID(activityId);

            if (activity == null)
            {
                Console.WriteLine("Aktiviteten blev ikke fundet.");
                return false;
            }

            if (activity.RegisteredCustomerIDs.Contains(customerId))
            {
                Console.WriteLine("Kunden er allerede tilmeldt aktiviteten.");
                return false;
            }

            activity.RegisteredCustomerIDs.Add(customerId);
            _activityRepo.UpdateActivity(activity); // 👈 Bruger opdateringsmetode på enkelt objekt
            return true;
        }

    }
}

