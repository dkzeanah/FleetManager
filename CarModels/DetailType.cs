namespace BlazorApp1.CarModels
{
    public class DetailType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        //Navigation Properties
        public virtual ICollection<Detail> Details { get; set; }

    }
}
