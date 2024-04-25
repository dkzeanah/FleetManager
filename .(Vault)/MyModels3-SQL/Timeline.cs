using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Timeline
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ApplicationUserDetailId { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
