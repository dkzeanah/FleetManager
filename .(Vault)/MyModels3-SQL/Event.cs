using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Event
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int EventTypeId { get; set; }

    public string? UserId { get; set; }

    public DateTime Date { get; set; }

    public int CategoryId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Type { get; set; }

    public int? TeamTimelineId { get; set; }

    public int? TimelineId { get; set; }

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
