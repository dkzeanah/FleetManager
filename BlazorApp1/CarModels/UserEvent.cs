using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.CarModels
{
    public class UserEvent
    {
        public int UserEventId { get; set; }
        public int? EventId { get; set; }
        public string? UserId { get; set; }

        // public int? UserEventDetailId { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }
        public Event? Event { get; set; }
        //public UserEventDetail EventDetail { get; set;}
        public ICollection<UserEventDetail>? UserEventDetails { get; set; }

    }

}
