using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class TicketAttachment
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public string TicketId1 { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public virtual Ticket TicketId1Navigation { get; set; } = null!;
}
