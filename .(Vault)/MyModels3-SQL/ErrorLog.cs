using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class ErrorLog
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public string? ErrorDetails { get; set; }

    public int? ErrorPriority { get; set; }

    public string? ErrorNotes { get; set; }
}
