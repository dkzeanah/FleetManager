namespace BlazorApp1.CarModels
{
    public class CarLog
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }

        // Navigation property
        public Car Car { get; set; }
    }

}
