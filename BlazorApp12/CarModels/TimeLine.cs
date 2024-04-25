namespace BlazorApp1.CarModels
{
    public class Timeline
    {
        public int Id { get; set; }
        public string ApplicationUserDetailId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<UserCarEvent> Events { get; set; }
        public ApplicationUserDetail ApplicationUserDetail { get; set; }

        // You might also want a way to add events to the timeline.
        public void AddEvent(UserCarEvent eventToAdd)
        {
            Events.Add(eventToAdd);
        }

        // You can also add methods to filter or search the timeline.
        public List<UserCarEvent> GetEventsInDateRange(DateTime start, DateTime end)
        {
            return Events.Where(e => e.Date >= start && e.Date <= end).ToList();
        }

        // Or to get events of a specific type
        /*public List<UserCarEvent> GetEventsOfType(string eventTypeId)
        {
            return Events.Where(e => e.EventTypeId == eventTypeId); //.ToList();
        }*/
    }
}
