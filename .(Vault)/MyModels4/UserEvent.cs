using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class UserEvent
{
    public long Id { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string UserId { get; set; } = null!;

    public long? EventId { get; set; }

    public long UserDetailId { get; set; }

    public string ApplicationUserDetailId { get; set; } = null!;

    public long UserEventDetailId { get; set; }

    public string? ApplicationUserId { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }

    public virtual ApplicationUserDetail ApplicationUserDetail { get; set; } = null!;

    public virtual Event? Event { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual ICollection<UserEventDetail> UserEventDetails { get; set; } = new List<UserEventDetail>();
}
