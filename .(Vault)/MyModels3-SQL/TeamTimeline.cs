using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TeamTimeline
{
    public int Id { get; set; }

    public int TeamId { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Team Team { get; set; } = null!;
}
