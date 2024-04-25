using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class DriverStat
{
    public int Id { get; set; }

    public int TotalCount { get; set; }

    public int AverageDrivingHours { get; set; }

    public virtual ApplicationUserDetail? ApplicationUserDetail { get; set; }
}
