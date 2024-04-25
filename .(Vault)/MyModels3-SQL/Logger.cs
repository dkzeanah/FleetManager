using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Logger
{
    public int LoggerId { get; set; }

    public int CarId { get; set; }

    public string TypeLogger { get; set; } = null!;

    public int NumLoggers { get; set; }

    public DateTime LogTime { get; set; }

    public string LogText { get; set; } = null!;

    public int? Car2Id { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Car2? Car2 { get; set; }
}
