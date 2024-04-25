using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public virtual Role IdNavigation { get; set; } = null!;
}
