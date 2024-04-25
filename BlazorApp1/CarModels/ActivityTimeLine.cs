using BlazorApp1.Interfaces;

namespace BlazorApp1.CarModels
{
    public class ActivityTimeLine
    {
        private readonly IActivityService activityService;

        public ActivityTimeLine(IActivityService service)
        {
            activityService = service;
        }

        public void DisplayTimeLine()
        {
            foreach (var activity in activityService.GetRankedActivities())
            {
                Console.WriteLine($"{activity.Name}: Current Value: {activity.CurrentValue}");
                // Additional timeline logic goes here
            }
        }
    }
}
