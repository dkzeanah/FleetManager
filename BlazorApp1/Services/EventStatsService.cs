using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;

namespace BlazorApp1.Services
{
    public class EventStatsService : IStatsService<Event, EventStats>
    {
        private readonly ApplicationDbContext _context;
        //private readonly MockDbContext _mockContext;

        public EventStatsService(ApplicationDbContext context) //, MockDbContext mockContext)
        {
            _context = context;
           // _mockContext = mockContext;
        }

        public async Task<EventStats> GetStatsAsync()
        {
            var events = await _context.Events.ToListAsync();

            var stats = new EventStats
            {
                TotalCount = events.Count,
                //AverageDuration = events.Average(e => (e.EndTime - e.StartTime).TotalHours),
                // Add any other stats you need...
            };

            return stats;
        }
    }

}
