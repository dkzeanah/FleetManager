using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class ApplicationUser
{
    public string Id { get; set; } = null!;

    public string? FriendlyName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? TeamId { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public virtual ApplicationUserDetail? ApplicationUserDetail { get; set; }

    public virtual ApplicationUserStaticDetail? ApplicationUserStaticDetail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Team? Team { get; set; }

    public virtual ICollection<Ticket> TicketAssignees { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<Ticket> TicketCreators { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();

    public virtual ICollection<UserEventDetail> UserEventDetailApplicationUsers { get; set; } = new List<UserEventDetail>();

    public virtual ICollection<UserEventDetail> UserEventDetailUsers { get; set; } = new List<UserEventDetail>();

    public virtual ICollection<UserEvent> UserEvents { get; set; } = new List<UserEvent>();
}
