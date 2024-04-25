using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class CarEventDetail
{
    public long CarEventDetailId { get; set; }

    public long CarEventId { get; set; }

    public string Note { get; set; } = null!;

    public long? CarDetailId { get; set; }

    public virtual CarDetail? CarDetail { get; set; }

    public virtual CarEvent CarEvent { get; set; } = null!;
}
