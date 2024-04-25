using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Log
{
    public int LogId { get; set; }

    public string LogMessage { get; set; } = null!;

    public DateTime? LogTime { get; set; }
}
