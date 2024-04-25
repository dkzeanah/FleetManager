using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public interface ITicketStatsService
    {
        Task<TicketStats> GetTicketStatsAsync();
    }

    public class TicketStatsService : ITicketStatsService
    {
        private readonly ApplicationDbContext _context;

        public TicketStatsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TicketStats> GetTicketStatsAsync()
        {
            var tickets = await _context.Tickets.ToListAsync();

            var stats = new TicketStats
            {
                TotalCount = tickets.Count,
                OpenCount = tickets.Count(t => t.Status == "Open"),
                ClosedCount = tickets.Count(t => t.Status == "Closed"),
                HighPriorityCount = tickets.Count(t => t.Priority == "High"),
                AvgTimeToClose = tickets.Where(t => t.ClosedAt.HasValue).Average(t => (t.ClosedAt.Value - t.CreatedAt).TotalDays)
            };

            // Additional stats computations...

            return stats;
        }
    }

   

}
