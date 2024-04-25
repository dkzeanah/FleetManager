using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Category
{
    public long CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public long DefaultPriority { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
