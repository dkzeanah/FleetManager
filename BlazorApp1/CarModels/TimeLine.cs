namespace BlazorApp1.CarModels
{
    public class Timeline
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Event> Events { get; set; }

        // You might also want a way to add events to the timeline.
        public void AddEvent(Event eventToAdd)
        {
            Events.Add(eventToAdd);
        }

        // You can also add methods to filter or search the timeline.
        public List<Event> GetEventsInDateRange(DateTime start, DateTime end)
        {
            return Events.Where(e => e.Date >= start && e.Date <= end).ToList();
        }

        // Or to get events of a specific type
      //  public List<Event> GetEventsOfType(string eventType)
        //{
         //   return Events.Where(e => e.Type == eventType).ToList();
      //  }
    }
}
