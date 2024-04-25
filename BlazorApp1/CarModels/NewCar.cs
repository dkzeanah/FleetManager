using BlazorApp1.CarModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;
[Table("NewCar")]

public partial class NewCar
{
    //private 
    public int Id { get; set; }
    public string? Name { get; set; } 
    public string? Make { get; set; }
    public string? Model { get; set; } 
    public bool? Adas { get; set; }

    public int? Year { get; set; }

    public string? TeleGeneration { get; set; } = null!;

    public int? Miles { get; set; }

    public string? Location { get; set; }
    public string? Tagnumber { get; set; }
    public string? Vin { get; set; }
    public string? Finas { get; set; }
    public int? SourceId { get; set; }
    public Source? Source { get; set; }
    //nav CarStaticDetail

    // TODO: Car is the Principal entity and should not have a foreign key property for CarStaticDetailId
    // public int CarStaticDetailId { get; set; }
    public virtual CarStaticDetail? CarStaticDetail { get; set; }


    //nav CarDetails ->
   // public int? CarDetail { get; set; }
    //public ICollection<CarDetail>? CarDetails { get; set; }

    //nav CarStatus
    public int? CarStatusId { get; set; }
    public ICollection<CarStatus>? CarStatus { get; set; }

    public int? LoggerId { get; set; }
    public virtual ICollection<NewCarLogger>? NewCarLoggers { get; set; } = new List<NewCarLogger>();
    public string? UserId { get; set; }
    public double? Mileage { get; set; }


    public override string ToString()
    {
        return $"CarId: {Id}, Make: {Make}, Model: {Model}, Year: {Year}, TeleGeneration: {TeleGeneration}, Miles: {Miles}, Location: {Location}";
    }
}
