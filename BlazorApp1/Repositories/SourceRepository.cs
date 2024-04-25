using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class SourceRepository : ISourceRepository
    {
        private readonly Data.ApplicationDbContext _context;

        public SourceRepository(Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Source>> GetAllSourcesAsync()
        {
            return await _context.Sources.ToListAsync();
        }


        public async Task<Source> GetSourceByIdAsync(int id)
        {
            return await _context.Sources.FindAsync(id);
        }

        public async Task AddSourceAsync(Source source)
        {
            _context.Sources.Add(source);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSourceAsync(Source source)
        {
            _context.Entry(source).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSourceAsync(int id)
        {
            var source = await _context.Sources.FindAsync(id);
            if (source != null)
            {
                _context.Sources.Remove(source);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Source>> GetSourcesAsync()
        {
            return await GetAllSourcesAsync();
        }
    }
}
