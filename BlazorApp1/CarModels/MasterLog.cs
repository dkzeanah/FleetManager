using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class MasterLog
{
    public long Id { get; set; }

    public string Message { get; set; } = null!;

    public string? Time { get; set; }
}
