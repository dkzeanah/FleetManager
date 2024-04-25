

using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Services
{
    public class BlankRepository : IBlankRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public BlankRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Blank>> GetAll()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Blanks.ToListAsync();
        }

        public async Task<Blank> Get(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Blanks.FindAsync(id);
        }

        public async Task Add(Blank blank)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Blanks.Add(blank);
            await context.SaveChangesAsync();
        }

        public async Task Update(Blank blank)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Blanks.Update(blank);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            var blank = await context.Blanks.FindAsync(id);
            if (blank != null)
            {
                context.Blanks.Remove(blank);
                await context.SaveChangesAsync();
            }
        }
    }
}


