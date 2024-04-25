using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;
[Table("Car2s")]

public partial class Car2
{
    public int Id { get; set; }

    public string? Make { get; set; } = null!;

    public string? Model { get; set; } = null!;

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; } = null!;

    public int? Miles { get; set; }

    public string? Location { get; set; }

    public int? SourceId { get; set; }

    public virtual CarStaticDetail? CarStaticDetail { get; set; }
   // public ICollection<CarStaticDetail> CarStaticDetails { get; set; }


    public virtual ICollection<Logger>? Loggers { get; set; } = new List<Logger>();
    public string? UserId { get;  set; }
    //public double Mileage { get;  set; }

    public override string ToString()
    {
        return $"CarId: {Id}, Make: {Make}, Model: {Model}, Year: {Year}, TeleGeneration: {TeleGeneration}, Miles: {Miles}, Location: {Location}";
    }
}
