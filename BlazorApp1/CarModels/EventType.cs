using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels
{
    public partial class EventType
    {
        // Ids
        public int Id { get; set; }
       // public int EventTypeId { get; set; }
      //  public int EventId { get; set; }


        //primary information
        public string Name { get; set; } = null!;

        // link event model/obj
       // public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    }
}