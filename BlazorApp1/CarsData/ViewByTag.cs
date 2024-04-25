using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class ViewByTag
{
    public int CarId { get; set; }

    public string Tag { get; set; } = null!;

    public string Finas { get; set; } = null!;

    public string Vinlast4 { get; set; } = null!;

    public string? HarnessStatus { get; set; }

    public string? FullVin { get; set; }

    public string? SoftwareVersion { get; set; }

    public bool? Star3 { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public int Miles { get; set; }

    public string? Location { get; set; }
}
