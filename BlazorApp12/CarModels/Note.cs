using System.CodeDom;

namespace BlazorApp1.CarModels
{
    public class Note
    {
        public int Id { get; set; }  // Unique identifier
        public string Title { get; set; }  // The title of the note
        public string Content { get; set; }  // The content of the note
        public string AuthorId { get; set; }  // The Id of the author who wrote the note
        public ApplicationUser Author { get; set; }  // The author who wrote the note
        public DateTime CreatedAt { get; set; }  // When the note was created
        public DateTime? UpdatedAt { get; set; }  // When the note was last updated
        public DateTime? DeletedAt { get; set; }  // When the note was deleted, if it was
        public bool IsDeleted { get; set; }  // Flag indicating whether the note is deleted
        public ICollection<NoteAttachment> Attachments { get; set; }  // Files attached to the note
        public ICollection<NoteComment> Comments { get; set; }  // Comments on the note
        public ICollection<NoteTag> Tags { get; set; }  // Tags associated with the note
    }
}
