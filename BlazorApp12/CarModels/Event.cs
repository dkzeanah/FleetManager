

namespace BlazorApp1.CarModels
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get;  } 
        public string? UserId { get; set; }
        public int UserEventId { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; } = new();
        public List<UserEvent> UserEvents { get; } = new();
        public DateTime Date { get; set; }
    }
}
