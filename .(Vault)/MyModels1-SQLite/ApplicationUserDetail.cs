using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class ApplicationUserDetail
{
    public string Id { get; set; } = null!;

    public string ApplicationUserId { get; set; } = null!;

    public long UserEventsId { get; set; }

    public long? DriverStatsId { get; set; }

    public long? TimelineId { get; set; }

    public long? DetailId { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    public virtual Detail? Detail { get; set; }

    public virtual DriverStat? DriverStats { get; set; }

    public virtual ICollection<Ticket> TicketApplicationUserDetails { get; set; } = new List<Ticket>();

    public virtual ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();

    public virtual Ticket? TicketIdNavigation { get; set; }

    public virtual ICollection<Timeline> Timelines { get; set; } = new List<Timeline>();

    public virtual ICollection<UserEvent> UserEvents { get; set; } = new List<UserEvent>();
}
