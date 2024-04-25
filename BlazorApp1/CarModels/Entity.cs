using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Entity
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EntityAttributeValue> EntityAttributeValues { get; set; } = new List<EntityAttributeValue>();
}
