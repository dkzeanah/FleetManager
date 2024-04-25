using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class SimpleEventTypeRepository : ISimpleEventTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public SimpleEventTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SimpleEventType>> GetAllSimpleEventTypesAsync()
        {
            return await _context.SimpleEventTypes.ToListAsync();
        }


        public async Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id)
        {
            return await _context.SimpleEventTypes.FindAsync(id);
        }

        public async Task AddSimpleEventTypeAsync(SimpleEventType eventType)
        {
            _context.SimpleEventTypes.Add(eventType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSimpleEventTypeAsync(SimpleEventType eventType)
        {
            _context.Entry(eventType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSimpleEventTypeAsync(int id)
        {
            var eventType = await _context.SimpleEventTypes.FindAsync(id);
            if (eventType != null)
            {
                _context.SimpleEventTypes.Remove(eventType);
                await _context.SaveChangesAsync();
            }
        }

        public Task<IEnumerable<SimpleEventType>> GetSimpleEventTypesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
