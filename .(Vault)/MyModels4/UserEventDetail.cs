using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class UserEventDetail
{
    public long Id { get; set; }

    public long? CarId { get; set; }

    public string UserId { get; set; } = null!;

    public string ApplicationUserId { get; set; } = null!;

    public long UserEventId { get; set; }

    public long UserEventDetailGrandularId { get; set; }

    public long TextId { get; set; }

    public string DateAdded { get; set; } = null!;

    public long? DetailId { get; set; }

    public long? EventId { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    public virtual Car? Car { get; set; }

    public virtual Detail? Detail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();

    public virtual Event? Event { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual UserEvent UserEvent { get; set; } = null!;

    public virtual ICollection<UserEventDetailText> UserEventDetailTexts { get; set; } = new List<UserEventDetailText>();
}
