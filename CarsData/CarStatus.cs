using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class CarStatus
{
    public int CarId { get; set; }
    public string? HarnessStatus { get; set; }
    public string? SoftwareVersion { get; set; }
    public int Miles { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public static implicit operator CarStatus(List<CarStatus> v)
    {
        throw new NotImplementedException();
    }
}
