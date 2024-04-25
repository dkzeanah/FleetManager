using BlazorApp1.CarModels.Utils;

namespace BlazorApp1.Interfaces
{
    public interface IActivityService
    {
        void AddActivity(IActivity activity);
        void UpdateActivityValue(string activityName, decimal newValue);
        IEnumerable<IActivity> GetRankedActivities();
    }

    

}
