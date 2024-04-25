using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class UserEventDetailText
{
    public long Id { get; set; }

    public string Text { get; set; } = null!;

    public long UserEventDetailId { get; set; }

    public virtual UserEventDetail UserEventDetail { get; set; } = null!;
}
