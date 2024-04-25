﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public partial class Event
    {
        // Ids
        //[Key]
        [Key]
        [Column("Id")] // Make sure this name matches the column name in your database
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies that the database generates this value

        public int Id { get; set; }
        public int? CarId { get; set; }
        //public int? EventTypeId { get; set; }
        public string? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }// = null!;


        //used by eventranker
        public Category? Category { get; set; }

        //public int UserEventDetailId { get; set; }


        //primary information
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? Date { get;  set; }
        public int? EventTypeId { get; set; }
        public virtual EventType? EventType { get; set; } //= null!;

        public int? SimpleEventTypeId { get; set; }
        public virtual SimpleEventType? SimpleEventType { get; set; } //= null!;
       
        public string? Type { get;  set; }
    }
}