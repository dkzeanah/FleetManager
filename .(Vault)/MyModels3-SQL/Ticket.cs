using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Ticket
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CreatorId { get; set; } = null!;

    public string AssigneeId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? ClosedAt { get; set; }

    public string Status { get; set; } = null!;

    public string Severity { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public string ApplicationUserDetailId { get; set; } = null!;

    public virtual ApplicationUser Assignee { get; set; } = null!;

    public virtual ApplicationUser Creator { get; set; } = null!;
}
