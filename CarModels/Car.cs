using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Car
{
    public int CarId { get; set; }

    public string? Make { get; set; } = null!;

    public string? Model { get; set; } = null!;

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; } = null!;

    public int? Miles { get; set; }

    public string? Location { get; set; }

    public int? SourceId { get; set; }

    public virtual CarDetail? CarDetail { get; set; }
   // public ICollection<CarStaticDetail> CarStaticDetails { get; set; }

   // public int LoggerId { get; set; }
   // public virtual ICollection<Logger>? Loggers { get; set; } = new List<Logger>();
    public string? UserId { get;  set; }
    public virtual ApplicationUser? User { get; set; }
    //public double Mileage { get;  set; }

    public override string ToString()
    {
        return $"CarId: {CarId}, Make: {Make}, Model: {Model}, Year: {Year}, TeleGeneration: {TeleGeneration}, Miles: {Miles}, Location: {Location}";
    }
}
