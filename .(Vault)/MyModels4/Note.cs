using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class Note
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string AuthorId { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public string? UpdatedAt { get; set; }

    public string? DeletedAt { get; set; }

    public long IsDeleted { get; set; }

    public virtual ApplicationUser Author { get; set; } = null!;

    public virtual ICollection<NoteAttachment> NoteAttachments { get; set; } = new List<NoteAttachment>();

    public virtual ICollection<NoteComment> NoteComments { get; set; } = new List<NoteComment>();

    public virtual ICollection<NoteTag> NoteTags { get; set; } = new List<NoteTag>();
}
