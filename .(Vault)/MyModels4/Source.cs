using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class Source
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
