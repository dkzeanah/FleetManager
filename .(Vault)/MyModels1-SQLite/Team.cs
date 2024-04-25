using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Team
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    public virtual TeamTimeline? TeamTimeline { get; set; }
}
