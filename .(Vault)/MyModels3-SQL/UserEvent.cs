using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class UserEvent
{
    public int Id { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string UserId { get; set; } = null!;

    public int EventId { get; set; }

    public int UserDetailId { get; set; }

    public int UserEventDetailId { get; set; }

    public string ApplicationUserDetailId { get; set; } = null!;

    public virtual Event Event { get; set; } = null!;

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual ICollection<UserEventDetail> UserEventDetails { get; set; } = new List<UserEventDetail>();
}
