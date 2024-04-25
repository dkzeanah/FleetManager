using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class ApplicationUserDetail
{
    public int Id { get; set; }

    public string ApplicationUserId { get; set; } = null!;

    public int UserEventsId { get; set; }

    public int? DriverStatsId { get; set; }

    public int? TimelineId { get; set; }

    public int? DetailId { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    public virtual Detail? Detail { get; set; }

    public virtual DriverStat? DriverStats { get; set; }
}
