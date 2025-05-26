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

        public void UpdateActivity(Activity activity) // Updates specific information in activities
        {
            _activityRepo.UpdateActivity(activity);
        }
        public bool RegisterCustomerToActivity(int activityId, int customerId) // Registers a customer to an activity
        {
            var activity = _activityRepo.GetByID(activityId); // Get the activity by ID

            if (activity == null) // Check if the activity exists
            {
                Console.WriteLine("Aktiviteten blev ikke fundet.");
                return false; // Activity not found
            }

            if (activity.RegisteredCustomerIDs.Contains(customerId)) // Check if the customer is already registered for the activity
            {
                Console.WriteLine("Kunden er allerede tilmeldt aktiviteten.");
                return false;
            }

            activity.RegisteredCustomerIDs.Add(customerId);// Add the customer ID to the activity's registered customers list
            _activityRepo.UpdateActivity(activity); // Update the activity in the repository
            return true;
        }

    }
}

