using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class NoteComment
{
    public long Id { get; set; }

    public long NoteId { get; set; }

    public string Content { get; set; } = null!;

    public string AuthorId { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public virtual ApplicationUser Author { get; set; } = null!;

    public virtual Note Note { get; set; } = null!;
}
