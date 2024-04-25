using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace BlazorApp1.Repositories
{
    public class BlankRepository : IBlankRepository
    {
        private readonly ApplicationDbContext _context;

        public BlankRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Blank>> GetAll()
        {
            return await _context.Blanks.ToListAsync();
        }

        public async Task<Blank> Get(int id)
        {
            return await _context.Blanks.FindAsync(id);
        }

        public async Task Add(Blank entity)
        {
            _context.Blanks.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Blank entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _context.Blanks.FindAsync(id);
            if (entity != null)
            {
                _context.Blanks.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }

}
