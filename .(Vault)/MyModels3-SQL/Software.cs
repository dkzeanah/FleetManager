using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Software
{
    public int Id { get; set; }

    public string Unit { get; set; } = null!;

    public string SoftwareVersion { get; set; } = null!;

    public string? NextSoftwareVersion { get; set; }

    public DateTime? UploadDate { get; set; }

    public DateTime? FutureUploadDate { get; set; }

    public int? CarId { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
