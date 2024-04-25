namespace BlazorApp1.CarModels.MasterExample
{
    public class Tag
    {
        public int Id { get; set; } // Primary key
        public string Text { get; set; }

        public IList<Post> Posts { get; } = new List<Post>(); // Skip collection navigation
    }
}
