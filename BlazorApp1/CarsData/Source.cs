using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Source
{
    public int SourceId { get; set; }

    public string SourceName { get; set; } = null!;

    public string SourceType { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
