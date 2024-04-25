using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class TempLogger
{
    public int LoggerId { get; set; }

    public int CarId { get; set; }

    public string TypeLogger { get; set; } = null!;

    public int NumLoggers { get; set; }
}
