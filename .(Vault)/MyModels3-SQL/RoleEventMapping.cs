using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class RoleEventMapping
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public int DefaultEventTypeId { get; set; }
}
