using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TicketAttachment
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string FilePath { get; set; } = null!;

    public string TicketId1 { get; set; } = null!;
}
