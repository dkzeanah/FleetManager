using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class TruckStatus
{
    public int? TruckId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? StatusTime { get; set; }

    public virtual Truck Truck { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
