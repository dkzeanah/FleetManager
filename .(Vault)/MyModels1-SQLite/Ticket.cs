using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Ticket
{
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string ApplicationUserDetailId { get; set; } = null!;

    public string CreatorId { get; set; } = null!;

    public string AssigneeId { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public string? UpdatedAt { get; set; }

    public string? ClosedAt { get; set; }

    public string Status { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public virtual ApplicationUserDetail ApplicationUserDetail { get; set; } = null!;

    public virtual ApplicationUser Assignee { get; set; } = null!;

    public virtual ApplicationUser Creator { get; set; } = null!;

    public virtual ApplicationUserDetail IdNavigation { get; set; } = null!;

    public virtual ICollection<TicketAttachment> TicketAttachments { get; set; } = new List<TicketAttachment>();

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();

    public virtual ICollection<TicketTag> TicketTags { get; set; } = new List<TicketTag>();
}
