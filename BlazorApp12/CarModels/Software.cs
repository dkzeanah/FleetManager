using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Software
{
    public int Id { get; set; }

    public string Unit { get; set; } = null!;

    public string SoftwareVersion { get; set; } = null!;

    public string? NextSoftwareVersion { get; set; } = null!;
    public DateTime? UploadDate { get; set; }
    public DateTime? FutureUploadDate { get; set; }
    //nav
    public int? CarId { get; set; }
    public ICollection<Car>? Cars { get; set; }
}
