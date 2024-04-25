using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class UserEventDetail
{
    public int Id { get; set; }

    public int? CarId { get; set; }

    public string UserId { get; set; } = null!;

    public string ApplicationUserId { get; set; } = null!;

    public int UserEventId { get; set; }

    public int UserEventDetailGrandularId { get; set; }

    public int TextId { get; set; }

    public DateTime DateAdded { get; set; }

    public int? DetailId { get; set; }

    public int? EventId { get; set; }

    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    public virtual Car? Car { get; set; }

    public virtual Detail? Detail { get; set; }

    public virtual ICollection<Detail> Details { get; set; } = new List<Detail>();

    public virtual Event? Event { get; set; }

    public virtual ApplicationUser User { get; set; } = null!;

    public virtual UserEvent UserEvent { get; set; } = null!;

    public virtual ICollection<UserEventDetailText> UserEventDetailTexts { get; set; } = new List<UserEventDetailText>();
}
