using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class EventType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
