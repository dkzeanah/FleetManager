namespace BlazorApp1.CarModels
{
    public class NoteTag
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
        public string Tag { get; set; }
    }
}
