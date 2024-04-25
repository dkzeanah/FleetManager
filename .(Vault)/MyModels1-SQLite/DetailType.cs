using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class DetailType
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long? CarDetailId { get; set; }

    public virtual CarDetail? CarDetail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();
}
