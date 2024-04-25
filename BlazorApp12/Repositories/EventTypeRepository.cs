using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class EventTypeRepository : IEventTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public EventTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EventType>> GetAllEventTypesAsync()
        {
            return await _context.EventTypes.ToListAsync();
        }


        public async Task<EventType> GetEventTypeByIdAsync(int id)
        {
            return await _context.EventTypes.FindAsync(id);
        }

        public async Task AddEventTypeAsync(EventType eventType)
        {
            _context.EventTypes.Add(eventType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEventTypeAsync(EventType eventType)
        {
            _context.Entry(eventType).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEventTypeAsync(int id)
        {
            var eventType = await _context.EventTypes.FindAsync(id);
            if (eventType != null)
            {
                _context.EventTypes.Remove(eventType);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<EventType>> GetEventTypesAsync()
        {
            return await _context.EventTypes.ToListAsync();
        }

        public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            return await _context.RoleEventMappings.ToListAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            _context.RoleEventMappings.Update(roleEventMapping);
            await _context.SaveChangesAsync();
        }
    }
}
