using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class CarDetail
{
    public long Id { get; set; }

    public long CarId { get; set; }

    public long CarEventId { get; set; }

    public long DetailTypeId { get; set; }

    public long CarEventDetailId { get; set; }

    public long? DetailId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual CarEvent CarEvent { get; set; } = null!;

    public virtual ICollection<CarEventDetail> CarEventDetails { get; set; } = new List<CarEventDetail>();

    public virtual Detail? Detail { get; set; }

    public virtual ICollection<DetailType> DetailTypes { get; set; } = new List<DetailType>();
}
