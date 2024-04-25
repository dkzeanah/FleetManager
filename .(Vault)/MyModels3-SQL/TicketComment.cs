using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class TicketComment
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Content { get; set; } = null!;

    public string AuthorId { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string TicketId1 { get; set; } = null!;

    public virtual ApplicationUser Author { get; set; } = null!;
}
