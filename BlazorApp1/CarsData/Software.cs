using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Software
{
    public int SoftwareId { get; set; }

    public int CarId { get; set; }

    public string HeadUnit { get; set; } = null!;

    public string SoftwareVersion { get; set; } = null!;

    public string NextSoftwareVersion { get; set; } = null!;

    public virtual Car Car { get; set; } = null!;
}
