using System;
using System.Collections.Generic;

namespace BlazorApp1.MyModels3;

public partial class Car
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; }

    public int? Miles { get; set; }

    public string? Location { get; set; }

    public int? SourceId { get; set; }

    public int CarDetail { get; set; }

    public int CarStatusId { get; set; }

    public string? UserId { get; set; }

    public int? SoftwareId { get; set; }

    public virtual ICollection<CarDetail> CarDetails { get; set; } = new List<CarDetail>();

    public virtual ICollection<CarEvent> CarEvents { get; set; } = new List<CarEvent>();

    public virtual CarStaticDetail? CarStaticDetail { get; set; }

    public virtual ICollection<CarStatus> CarStatuses { get; set; } = new List<CarStatus>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<Logger> Loggers { get; set; } = new List<Logger>();

    public virtual Software? Software { get; set; }

    public virtual Source? Source { get; set; }

    public virtual ICollection<UserEventDetail> UserEventDetails { get; set; } = new List<UserEventDetail>();
}
