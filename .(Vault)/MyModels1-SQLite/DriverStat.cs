using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class DriverStat
{
    public long Id { get; set; }

    public long TotalCount { get; set; }

    public long AverageDrivingHours { get; set; }

    public virtual ApplicationUserDetail? ApplicationUserDetail { get; set; }
}
