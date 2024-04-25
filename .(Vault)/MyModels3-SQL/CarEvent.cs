using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class CarEvent
{
    public int CarEventId { get; set; }

    public int CarId { get; set; }

    public int EventId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<CarDetail> CarDetails { get; set; } = new List<CarDetail>();

    public virtual ICollection<CarEventDetail> CarEventDetails { get; set; } = new List<CarEventDetail>();

    public virtual Event Event { get; set; } = null!;
}
