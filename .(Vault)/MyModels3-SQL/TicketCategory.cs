using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TicketCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DefaultPriority { get; set; }
}
