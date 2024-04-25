using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TicketTag
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Tag { get; set; } = null!;
}
