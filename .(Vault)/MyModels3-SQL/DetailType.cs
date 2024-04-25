using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class DetailType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CarDetailId { get; set; }

    public virtual CarDetail? CarDetail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();
}
