using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Event
{
    public long Id { get; set; }

    public long CarId { get; set; }

    public long EventTypeId { get; set; }

    public string? UserId { get; set; }

    public string Date { get; set; } = null!;

    public long CategoryId { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Type { get; set; }

    public long? TeamTimelineId { get; set; }

    public long? TimelineId { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual ICollection<CarEvent> CarEvents { get; set; } = new List<CarEvent>();

    public virtual Category Category { get; set; } = null!;

    public virtual EventType EventType { get; set; } = null!;

    public virtual TeamTimeline? TeamTimeline { get; set; }

    public virtual Timeline? Timeline { get; set; }

    public virtual ApplicationUser? User { get; set; }

    public virtual ICollection<UserEventDetail> UserEventDetails { get; set; } = new List<UserEventDetail>();

    public virtual ICollection<UserEvent> UserEvents { get; set; } = new List<UserEvent>();
}
