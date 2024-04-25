using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class CarDetail
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int CarEventId { get; set; }

    public int DetailTypeId { get; set; }

    public int CarEventDetailId { get; set; }

    public int? DetailId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual CarEvent CarEvent { get; set; } = null!;

    public virtual ICollection<CarEventDetail> CarEventDetails { get; set; } = new List<CarEventDetail>();

    public virtual Detail? Detail { get; set; }

    public virtual ICollection<DetailType> DetailTypes { get; set; } = new List<DetailType>();
}
