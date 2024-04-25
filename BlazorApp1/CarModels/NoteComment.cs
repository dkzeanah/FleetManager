namespace BlazorApp1.CarModels
{
    public class NoteComment
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
