using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Team
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; } = new List<ApplicationUser>();

    public virtual TeamTimeline? TeamTimeline { get; set; }
}
