/*using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class CalendarRepository : ICalendarRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        public CalendarRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<CalendarUserDto>> GetCalendarUserDtosAsync()
        {
            using var _context = _contextFactory.CreateDbContext();
            return await _context.CalendarUserDtos.ToListAsync();
        }

        public async Task<List<CalendarEvent>> GetUserCalendarEventsAsync(string userId)
        {
            using var _context = _contextFactory.CreateDbContext();
            return await _context.CalendarEvents
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task AddCalendarEventAsync(CalendarEvent userCalendarEvent)
        {
            using var _context = _contextFactory.CreateDbContext();
            _context.CalendarEvents.Add(userCalendarEvent);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCalendarEventAsync(CalendarEvent userCalendarEvent)
        {
            using var _context = _contextFactory.CreateDbContext();
            _context.CalendarEvents.Update(userCalendarEvent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCalendarEventAsync(int eventId)
        {
            using var _context = _contextFactory.CreateDbContext();
            var eventToDelete = await _context.CalendarEvents.FindAsync(eventId);
            if (eventToDelete != null)
            {
                _context.CalendarEvents.Remove(eventToDelete);
                await _context.SaveChangesAsync();
            }
        }

        // Implement other methods similarly
    }

}
*/