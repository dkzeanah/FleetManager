using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class CarStatus
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int StatusId { get; set; }

    public DateTime? StatusTime { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;
}
