using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public int DefaultPriority { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
