namespace BlazorApp1.CarModels
{
    public class CarEvent
    {
        public int CarEventId { get; set; }
        public int CarId { get; set; }
        public int EventId { get; set; }

        public virtual Car Car { get; set; }
        public virtual Event Event { get; set; }

        public virtual ICollection<CarEventDetail> CarEventDetails { get; set; }
    }
}
