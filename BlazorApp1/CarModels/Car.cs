using BlazorApp1.CarModels.Utils;
using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public class Car : ILoggable
{
    public ICollection<Module>? Modules { get; set; }
    public List<CarModule>? CarModules { get; set; }
    public int? ParkingSpace { get; set; }
    public int CarId { get; set; }

    public string? Make { get; set; } = null!;

    public string? Model { get; set; } = null!;

    public double? Year { get; set; }

    public string? TeleGeneration { get; set; } = null!;

    public int? Miles { get; set; }

    public string? Location { get; set; }

    public int? SourceId { get; set; }
    //public virtual Source? Source { get; set; }
    //uses HasOne, no CarDetailId
    public virtual CarDetail? CarDetail { get; set; }

    public int? LoggerId { get; set; }
    public virtual ICollection<Logger>? Loggers { get;set; }
    public string? UserId { get;  set; }
    public virtual ApplicationUser? User { get; set; }
    //public double Mileage { get;  set; }

    public bool? HasLogger { get; set; }
    public bool? HasHarness { get; set; }
    public bool? HasTag { get; set; }
    public bool? IsAdas { get; set; }

    public override string ToString()
    {
        return $"CarId: {CarId}, Make: {Make}, Model: {Model}, Year: {Year}, TeleGeneration: {TeleGeneration}, Miles: {Miles}, Location: {Location}";
    }
}
