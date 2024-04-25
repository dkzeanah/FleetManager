using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels1;

public partial class NoteAttachment
{
    public long Id { get; set; }

    public long NoteId { get; set; }

    public string FilePath { get; set; } = null!;

    public virtual Note Note { get; set; } = null!;
}
