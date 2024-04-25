using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class CarEventDetail
{
    public int CarEventDetailId { get; set; }

    public int CarEventId { get; set; }

    public string Note { get; set; } = null!;

    public int? CarDetailId { get; set; }

    public virtual CarDetail? CarDetail { get; set; }

    public virtual CarEvent CarEvent { get; set; } = null!;
}
