namespace BlazorApp1.CarModels
{
    public class TruckDetail
    {
        public int TruckDetailId { get; set; }

        // Other properties that are unique to each car detail, e.g.
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; } // Vehicle Identification Number

        // Navigation properties
        public int TruckId { get; set; }
        public Truck Truck { get; set; } // Link to the Truck entity

        // This implies a car detail can have many detail types.
        public int? DetailTypeId { get; set; }
        public ICollection<DetailType>? DetailTypes { get; set; }

        // This implies that a car detail can be involved in many car events.
       // public ICollection<TruckEventDetail> TruckEventDetails { get; set; }
    }
}