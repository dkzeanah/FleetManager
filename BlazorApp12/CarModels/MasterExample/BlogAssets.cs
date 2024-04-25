namespace BlazorApp1.CarModels.MasterExample
{
    public class BlogAssets
    {
        public Guid Id { get; set; } // Primary key and foreign key
        public byte[] Banner { get; set; }

        public Blog Blog { get; set; } // Reference navigation
    }

    
}
