using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class ComplexEvent
    {
        // Ids
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies that the database generates this value
        [Key]
        [Column("Id")] // Make sure this name matches the column name in your database
        public int Id { get; set; }
        public int? CarId { get; set; }
        //public int? EventTypeId { get; set; }
        public string? UserId { get; set; }

       // public Category? Category { get; set; }

        //public int UserEventDetailId { get; set; }


        //primary information
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
       // public DateTime? Date { get;  set; }

        public virtual ApplicationUser? User { get; set; }// = null!;
        public int? SimpleEventTypeId { get; set; }
        public virtual EventType? EventType { get; set; } //= null!;

        // public virtual UserEventDetail? UserEventDetail { get; set; } //= null!;
        //public virtual ICollection<UserEvent> UserEvents { get; internal set;
        public int? UserEventId { get; set; }
        public int? EventDetailId { get; set; }
        public virtual ICollection<EventDetail>? EventDetails { get; set; }
        public virtual ICollection<UserEvent>? UserEvents { get; set; }
       // public string? Type { get;  set; }
    }
}
