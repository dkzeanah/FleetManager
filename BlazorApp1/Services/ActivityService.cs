using BlazorApp1.CarModels.Utils;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class ActivityService : IActivityService
    {
        private readonly List<IActivity> activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }

        public void UpdateActivityValue(string activityName, decimal newValue)
        {
            var activity = activities.FirstOrDefault(a => a.Name == activityName);
            activity?.UpdateValue(newValue);
        }

        public IEnumerable<IActivity> GetRankedActivities()
        {
            return activities.OrderByDescending(a => a.CurrentValue);
        }
    }
}
