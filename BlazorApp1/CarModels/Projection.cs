namespace BlazorApp1.CarModels
{
    public class Projection
    {
        public DateTime ProjectionStartDate { get; set; }
        public DateTime ProjectionEndDate { get; set; }
        public Dictionary<DateTime, int> ProjectedEventsCount { get; set; }

        // Depending on how you want to calculate projections, you might add methods like
        public void ProjectEventsBasedOnPastData(Timeline pastData)
        {
            // Your implementation here
        }
    }
}
