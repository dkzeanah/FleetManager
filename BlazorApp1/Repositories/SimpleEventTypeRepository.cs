using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class SimpleEventTypeRepository : ISimpleEventTypeRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        //private readonly ApplicationDbContext _context;

        public SimpleEventTypeRepository(IDbContextFactory<ApplicationDbContext> contextFactory) //ApplicationDbContext context)
        {
            //_context = context;
            _contextFactory = contextFactory;

        }

        public async Task<IEnumerable<SimpleEventType>> GetAllSimpleEventTypesAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.SimpleEventTypes.ToListAsync();
        }


        public async Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.SimpleEventTypes.FindAsync(id);
        }

        public async Task AddSimpleEventTypeAsync(SimpleEventType eventType)
        {
            using var context = _contextFactory.CreateDbContext();

            context.SimpleEventTypes.Add(eventType);
            await context.SaveChangesAsync();
        }

        public async Task UpdateSimpleEventTypeAsync(SimpleEventType eventType)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Entry(eventType).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteSimpleEventTypeAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var eventType = await context.SimpleEventTypes.FindAsync(id);
            if (eventType != null)
            {
                context.SimpleEventTypes.Remove(eventType);
                await context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<SimpleEventType>> GetSimpleEventTypesAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            throw new NotImplementedException();
        }
    }
}
