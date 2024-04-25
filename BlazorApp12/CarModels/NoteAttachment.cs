namespace BlazorApp1.CarModels
{
    public class NoteAttachment
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
        public string FilePath { get; set; }
    }
}
