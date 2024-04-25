using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class CarStatus
{
    public long Id { get; set; }

    public long CarId { get; set; }

    public long StatusId { get; set; }

    public string? StatusTime { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
