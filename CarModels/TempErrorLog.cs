using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class TempErrorLog
{
    public int ErrorId { get; set; }

    public int CarId { get; set; }

    public string? ErrorDetails { get; set; }

    public int? ErrorPriority { get; set; }

    public string? ErrorNotes { get; set; }
}
