using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Logger
{
    public long LoggerId { get; set; }

    public long CarId { get; set; }

    public string TypeLogger { get; set; } = null!;

    public long NumLoggers { get; set; }

    public string LogTime { get; set; } = null!;

    public string LogText { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;
}
