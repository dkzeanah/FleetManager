using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Timeline
{
    public long Id { get; set; }

    public string ApplicationUserDetailId { get; set; } = null!;

    public string EndDate { get; set; } = null!;

    public string StartDate { get; set; } = null!;

    public virtual ApplicationUserDetail ApplicationUserDetail { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
