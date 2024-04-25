using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class MasterLog
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? Time { get; set; }
}
