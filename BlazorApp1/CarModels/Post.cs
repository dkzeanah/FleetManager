namespace BlazorApp1.CarModels
{
    public class Post
    {
        public int Id { get; set; }
        public List<Tag> Tags { get; } = new();
        public List<PostTag> PostTags { get; } = new();
    }

   
}
