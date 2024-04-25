using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Repair
{
    public int RepairId { get; set; }

    public int CarId { get; set; }

    public int TechnicianId { get; set; }

    public string RepairDetails { get; set; } = null!;

    public DateTime RepairStart { get; set; }

    public DateTime RepairEnd { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual PlaceholderUser Technician { get; set; } = null!;
}
