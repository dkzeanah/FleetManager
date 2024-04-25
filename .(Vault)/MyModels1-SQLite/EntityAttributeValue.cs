using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class EntityAttributeValue
{
    public long Id { get; set; }

    public long EntityId { get; set; }

    public long AttributeId { get; set; }

    public string Value { get; set; } = null!;

    public virtual Attribute Attribute { get; set; } = null!;

    public virtual Entity Entity { get; set; } = null!;
}
