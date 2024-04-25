using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels4;

public partial class NoteTag
{
    public long Id { get; set; }

    public long NoteId { get; set; }

    public string Tag { get; set; } = null!;

    public virtual Note Note { get; set; } = null!;
}
