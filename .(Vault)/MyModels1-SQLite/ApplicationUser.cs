using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class ApplicationUser
{
    public string Id { get; set; } = null!;

    public string? FriendlyName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public long? TeamId { get; set; }

    public string? UserName { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? Email { get; set; }

    public string? NormalizedEmail { get; set; }

    public long EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public long PhoneNumberConfirmed { get; set; }

    public long TwoFactorEnabled { get; set; }

    public string? LockoutEnd { get; set; }

    public long LockoutEnabled { get; set; }

    public long AccessFailedCount { get; set; }

    public virtual ApplicationUserDetail? ApplicationUserDetail { get; set; }

    public virtual ApplicationUserStaticDetail? ApplicationUserStaticDetail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<NoteComment> NoteComments { get; set; } = new List<NoteComment>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual Team? Team { get; set; }

    public virtual ICollection<Ticket> TicketAssignees { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<Ticket> TicketCreators { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();

    public virtual ICollection<UserEvent> UserEventApplicationUsers { get; set; } = new List<UserEvent>();

    public virtual ICollection<UserEventDetail> UserEventDetailApplicationUsers { get; set; } = new List<UserEventDetail>();

    public virtual ICollection<UserEventDetail> UserEventDetailUsers { get; set; } = new List<UserEventDetail>();

    public virtual ICollection<UserEvent> UserEventUsers { get; set; } = new List<UserEvent>();
}
