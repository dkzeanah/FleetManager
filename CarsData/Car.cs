using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Car
{
    public int CarId { get; set; }
    public string Make { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
    public string TeleGeneration { get; set; } = null!;
    public string? Location { get; set; }
    public int SourceId { get; set; }
    public virtual ICollection<ErrorLog> ErrorLogs { get; set; } = new List<ErrorLog>();
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
    public virtual ICollection<Logger> Loggers { get; set; } = new List<Logger>();
    public virtual CarDetail? CarDetail { get; set; } = new List<CarDetail>();
    public virtual CarStatus CarStatus { get; set; }  = new List<CarStatus>();
}
//public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();
//public virtual ICollection<Software> Softwares { get; set; } = new List<Software>();
//public virtual Source Source { get; set; } = null!;
