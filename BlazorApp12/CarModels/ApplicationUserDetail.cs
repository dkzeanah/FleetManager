using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorApp1.CarModels
{

    public class ApplicationUserDetail
    {
        public string Id { get; set; }
        [Required]
        [ForeignKey("ApplicationUserId")]

        public string ApplicationUserId { get; set; }
        //[Required]
        public virtual ApplicationUser ApplicationUser { get; set; }
        // Every user knows of their many events, events know of 1 user.
        public int UserEventsId { get; set; }
        public virtual ICollection<UserEvent>? UserEvents { get; set; }
        // every user knows many tickets, tickets know one user
        [NotMapped]
        public virtual ICollection<Ticket>? TicketsCreated { get; set; }
        [NotMapped]
        public virtual ICollection<Ticket>? TicketsAssigned { get; set; }
        [NotMapped]
        public virtual ICollection<TicketHistory>? TicketHistories { get; set; }

    // Foreign key for DriverStats
    public int? DriverStatsId { get; set; }
    // Navigation property for DriverStats
    public virtual DriverStats? DriverStats { get; set; }

    // one to many with timeslines
    public int? TimelineId { get; set; }
    public virtual ICollection<Timeline>? Timelines { get; set; }

        public static explicit operator ApplicationUserDetail(int? v)
        {
            throw new NotImplementedException();
        }

       
    }
}
