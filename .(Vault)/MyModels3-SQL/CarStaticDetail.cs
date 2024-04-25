using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class CarStaticDetail
{
    public int Id { get; set; }

    public string Vin { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public string Finas { get; set; } = null!;

    public bool? Adas { get; set; }

    public int? CarId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual ICollection<Car2> Car2s { get; set; } = new List<Car2>();
}
