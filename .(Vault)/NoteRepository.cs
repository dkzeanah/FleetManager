using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;
using Note = BlazorApp1.Data.Note;

public interface INoteRepository
{
    Task<Note> GetNoteAsync(int id);
    Task<List<Note>> GetNotesAsync();
    Task<Note> AddNoteAsync(BlazorApp1.Data.Note note);
    Task<Note> UpdateNoteAsync(BlazorApp1.Data.Note note);
    Task DeleteNoteAsync(int id);
}

public class NoteRepository : BlazorApp1.Data.INoteRepository
{
    private readonly ApplicationSQLiteDbContext _context;
    private readonly CalendarDbContext _memContext;

    public NoteRepository(ApplicationSQLiteDbContext context, CalendarDbContext memcontext)
    {
        _context = context;
        _memContext = memcontext;
    }

    public async Task<Note> GetNoteAsync(int id)
    {
        return await _context.Notes.FindAsync(id);
    }

    public async Task<List<Note>> GetNotesAsync()
    {
        return await _context.Notes.ToListAsync();
    }

    public async Task<Note> AddNoteAsync(Note note)
    {
        var result = await _context.Notes.AddAsync(note);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Note> UpdateNoteAsync(Note note)
    {
        var result = _context.Notes.Update(note);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task DeleteNoteAsync(int id)
    {
        var note = await _context.Notes.FindAsync(id);
        if (note != null)
        {
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
        }
    }
}
