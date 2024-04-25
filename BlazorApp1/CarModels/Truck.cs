using BlazorApp1.CarModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;
[Table("Truck")]

public partial class Truck
{
    //private 
    public int Id { get; set; }
    public string? Name { get; set; } = null!;
    public string? Make { get; set; } 
    public string? Model { get; set; } = null!;

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; } = null!;

    public int? Miles { get; set; }

    public string? Location { get; set; }
    public string? Tagnumber { get; set; }
    public string? Vin { get; set; }
    public string? Finas { get; set; }
    public bool? Adas { get; set; }

    public int? SourceId { get; set; }
    public Source? Source { get; set; }

    public virtual TruckStaticDetail? TruckStaticDetail { get; set; }
    public int TruckDetail { get; set; }
    public ICollection<TruckDetail>? TruckDetails { get; set; }

    public int TruckStatusId { get; set; }
    public ICollection<TruckStatus>? TruckStatus { get; set; }

    public int? NewTruckLoggerId { get; set; }
    public virtual ICollection<NewTruckLogger>? NewTruckLoggers { get; set; } = new List<NewTruckLogger>();
    public string? UserId { get;  set; }
    //public double Mileage { get;  set; }

   
    public override string ToString()
    {
        return $"TruckId: {Id}, Make: {Make}, Model: {Model}, Year: {Year}, TeleGeneration: {TeleGeneration}, Miles: {Miles}, Location: {Location}";
    }
}
