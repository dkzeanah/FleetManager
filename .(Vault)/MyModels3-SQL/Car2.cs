using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Car2
{
    public int Id { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; }

    public int? Miles { get; set; }

    public string? Location { get; set; }

    public int? SourceId { get; set; }

    public int? CarStaticDetailId { get; set; }

    public string? UserId { get; set; }

    public virtual CarStaticDetail? CarStaticDetail { get; set; }

    public virtual ICollection<Logger> Loggers { get; set; } = new List<Logger>();
}
