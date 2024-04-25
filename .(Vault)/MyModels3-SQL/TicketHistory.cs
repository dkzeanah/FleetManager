using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TicketHistory
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Change { get; set; } = null!;

    public DateTime ChangedAt { get; set; }

    public string ChangedById { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public int UserDetailId { get; set; }

    public string TicketId1 { get; set; } = null!;

    public string UserDetailId1 { get; set; } = null!;

    public virtual ApplicationUser Owner { get; set; } = null!;
}
