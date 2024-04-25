using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Order>().OwnsOne(
            order => order.ShippingInfo, ownedNavigationBuilder =>
            {
                ownedNavigationBuilder.ToJson();
                ownedNavigationBuilder.OwnsMany(si => si.Shipments);
                ownedNavigationBuilder.OwnsMany(si => si.Deliveries);
            });*/
        }
        public DbSet<BlazorApp1.Data.Note> Notes { get; set; }
        //public DbSet<BlazorApp1.CarModels.Order> Orders { get; set; }
    }
    public class Note
    {
        public int Id { get; set; }  // Unique identifier
        public string Title { get; set; }  // The title of the note
        public string Content { get; set; }  // The content of the note
        public string AuthorId { get; set; }  // The Id of the author who wrote the note
        public DateTime CreatedAt { get; set; }  // When the note was created
        public DateTime? UpdatedAt { get; set; }  // When the note was last updated
        public bool IsDeleted { get; set; }  // Flag indicating whether the note is deleted

        /*public ApplicationUser Author { get; set; }  // The author who wrote the note
        
        public DateTime? DeletedAt { get; set; }  // When the note was deleted, if it was
        public bool IsDeleted { get; set; }  // Flag indicating whether the note is deleted
        public ICollection<NoteAttachment> Attachments { get; set; }  // Files attached to the note
        public ICollection<NoteComment> Comments { get; set; }  // Comments on the note
        public ICollection<NoteTag> Tags { get; set; }  // Tags associated with the note*/
    }
    public interface INoteRepository
    {
        Task<BlazorApp1.Data.Note> GetNoteAsync(int id);
        Task<List<BlazorApp1.Data.Note>> GetNotesAsync();
        Task<BlazorApp1.Data.Note> AddNoteAsync(BlazorApp1.Data.Note note);
        Task<BlazorApp1.Data.Note> UpdateNoteAsync(BlazorApp1.Data.Note note);
        Task DeleteNoteAsync(int id);
    }
}
