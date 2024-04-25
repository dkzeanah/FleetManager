using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class DriverStat
{
    public long Id { get; set; }

    public long TotalMiles { get; set; }

    public long AverageDrivingHours { get; set; }

    public virtual ApplicationUserDetail? ApplicationUserDetail { get; set; }
}
