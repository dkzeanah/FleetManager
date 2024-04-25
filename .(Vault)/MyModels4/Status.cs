using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class Status
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarStatus> CarStatuses { get; set; } = new List<CarStatus>();
}
