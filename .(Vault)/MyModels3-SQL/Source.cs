using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Source
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
