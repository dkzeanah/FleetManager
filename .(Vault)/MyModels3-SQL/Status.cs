using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Status
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<CarStatus> CarStatuses { get; set; } = new List<CarStatus>();
}
