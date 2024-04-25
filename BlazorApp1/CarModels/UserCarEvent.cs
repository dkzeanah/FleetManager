using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels
{
    public partial class UserCarEvent
    {
        // Ids
        public int Id { get; set; }
        public int CarId { get; set; }
        public int EventTypeId { get; set; }
        public string? UserId { get; set; }
        public DateTime Date { get; set; }

        //public int CategoryId { get; set; }
        //public Category? Category { get; set; }

        //public int UserEventDetailId { get; set; }


        //primary information
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }


        public virtual ApplicationUser? User { get; set; }// = null!;
        public virtual EventType? EventType { get; set; } //= null!;
        public virtual ICollection<UserEventDetail> UserEventDetails { get;  set; }
        public virtual ICollection<UserEvent> UserEvents { get;  set; }
        // public virtual UserEventDetail? UserEventDetail { get; set; } //= null!;
        //public virtual ICollection<UserEvent> UserEvents { get; internal set;
        // public virtual ICollection<UserEventDetail>? EventDetails { get; set; }
        //public virtual ICollection<UserEvent>? UserEvents { get; set; }
        // public string? Tag { get;  set; }
        //public string? Type { get; set; }
        /*        public double Category { get; internal set; }
        */        //public Car? Car { get; internal set; }
                  // public List<CarEvent> CarEvents { get; internal set; }
    }
}
