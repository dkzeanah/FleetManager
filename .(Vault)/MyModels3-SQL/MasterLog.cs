using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class MasterLog
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public DateTime? Time { get; set; }
}
