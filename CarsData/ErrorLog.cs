using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class ErrorLog
{
    public int ErrorId { get; set; }

    public int CarId { get; set; }

    public string? ErrorDetails { get; set; }

    public int? ErrorPriority { get; set; }

    public string? ErrorNotes { get; set; }

    public virtual Car Car { get; set; } = null!;
}
