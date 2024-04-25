using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Issue
{
    public int IssueId { get; set; }

    public string Summary { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Priority { get; set; } = null!;

    public string AssignedTo { get; set; } = null!;

    public string System { get; set; } = null!;

    public string ModifiedBy { get; set; } = null!;

    public string ModifiedAt { get; set; } = null!;

    public string ModifiedByUser { get; set; } = null!;

    public string SubmittedBy { get; set; } = null!;

    public string SubmittedAt { get; set; } = null!;
}
