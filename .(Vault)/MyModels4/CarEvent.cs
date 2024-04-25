using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class CarEvent
{
    public long CarEventId { get; set; }

    public long CarId { get; set; }

    public long EventId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<CarDetail> CarDetails { get; set; } = new List<CarDetail>();

    public virtual ICollection<CarEventDetail> CarEventDetails { get; set; } = new List<CarEventDetail>();

    public virtual Event Event { get; set; } = null!;
}
