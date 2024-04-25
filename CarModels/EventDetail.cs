namespace BlazorApp1.CarModels
{
    public class EventDetail
    {
        public int EventDetailId { get; set; }
        public int DetailId { get; set; }
        public int EventId { get; set; }
       // public string UserId { get; set; }
        //public string DetailText { get; set; }
        public DateTime DateAdded { get; set; }

        // public ApplicationUser ApplicationUser { get; set; }
        public virtual Event Event { get; set; }
    }
}
