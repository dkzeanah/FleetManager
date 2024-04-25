using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class TicketHistory
{
    public long Id { get; set; }

    public long TicketId { get; set; }

    public string? TicketId1 { get; set; }

    public string Change { get; set; } = null!;

    public string ChangedAt { get; set; } = null!;

    public string ChangedById { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public long UserDetailId { get; set; }

    public string UserDetailId1 { get; set; } = null!;

    public virtual ApplicationUser Owner { get; set; } = null!;

    public virtual Ticket? TicketId1Navigation { get; set; }

    public virtual ApplicationUserDetail UserDetailId1Navigation { get; set; } = null!;
}
