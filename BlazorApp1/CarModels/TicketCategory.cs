using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class TicketCategory
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long DefaultPriority { get; set; }
}
