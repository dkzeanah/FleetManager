using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class Detail
{
    public long Id { get; set; }

    public long DetailTypeId { get; set; }

    public string Value { get; set; } = null!;

    public string? ApplicationUserId { get; set; }

    public string Discriminator { get; set; } = null!;

    public string? Text { get; set; }

    public string? UserId { get; set; }

    public long? UserEventId { get; set; }

    public long? UserEventDetailId { get; set; }

    public string? Note { get; set; }

    public virtual ApplicationUser? ApplicationUser { get; set; }

    public virtual ICollection<ApplicationUserDetail> ApplicationUserDetails { get; set; } = new List<ApplicationUserDetail>();

    public virtual ICollection<CarDetail> CarDetails { get; set; } = new List<CarDetail>();

    public virtual DetailType DetailType { get; set; } = null!;

    public virtual UserEventDetail? UserEventDetail { get; set; }

    public virtual ICollection<UserEventDetail> UserEventDetails { get; set; } = new List<UserEventDetail>();
}
