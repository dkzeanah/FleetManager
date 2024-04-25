using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class CarDetail
{
    public int CarId { get; set; }

    public string Tag { get; set; } = null!;

    public string Finas { get; set; } = null!;

    public string Vinlast4 { get; set; } = null!;

    

    public string? FullVin { get; set; }

    //public string? SoftwareVersion { get; set; }
    public bool ADAS { get; set; }

    public string? Star { get; set; }  // This was previously Star3 and was a boolean.

   

    public virtual Car Car { get; set; } = null!;

    public static implicit operator CarDetail(List<CarDetail> v)
    {
        throw new NotImplementedException();
    }
}
