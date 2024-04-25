using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class TeamTimeline
{
    public long Id { get; set; }

    public long TeamId { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Team Team { get; set; } = null!;
}
