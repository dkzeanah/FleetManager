namespace BlazorApp1.CarModels
{
    public class Tag
    {
        public int Id { get; set; }
        public List<Post> Posts { get; } = new();
        public List<PostTag> PostTags { get; } = new();
    }

   
}
