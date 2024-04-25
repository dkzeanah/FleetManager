using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class UserEventDetailText
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;

    public int UserEventDetailId { get; set; }

    public virtual UserEventDetail UserEventDetail { get; set; } = null!;
}
