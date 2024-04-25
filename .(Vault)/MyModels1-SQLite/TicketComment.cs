using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class TicketComment
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public string TicketId1 { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string AuthorId { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public virtual ApplicationUser Author { get; set; } = null!;

    public virtual Ticket TicketId1Navigation { get; set; } = null!;
}
