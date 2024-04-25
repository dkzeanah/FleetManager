namespace BlazorApp1.CarModels
{
    public class EventLog
    {
        public int EventLogId { get; set; }
        public int EventId { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }

        // Navigation 
        public UserCarEvent UserCarEvent { get; set; }
    }

}
