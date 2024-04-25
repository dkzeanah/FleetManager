using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels
{
    //[Table("CarDetails")]

    public class CarDetail
    {
        public int Id { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; } // Link to the Car entity


        public int CarEventId { get; set; }
        public CarEvent CarEvent { get; set; }
        
        // This implies a car detail can have many detail types.
        public int DetailTypeId { get; set; }
        public ICollection<DetailType> DetailTypes { get; set; }

        // This implies that a car detail can be involved in many car events.
        public int CarEventDetailId { get; set; }
        public ICollection<CarEventDetail> CarEventDetails { get; set; }
    }
}