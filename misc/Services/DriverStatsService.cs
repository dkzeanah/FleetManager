using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class DriverStatsService : IStatsService<Driver, DriverStats>
    {
        private readonly ApplicationDbContext _context;

        public DriverStatsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DriverStats> GetStatsAsync()
        {
            var drivers = await _context.Drivers.ToListAsync();

            var stats = new DriverStats
            {
                TotalCount = drivers.Count,
                AverageDrivingHours = (double)drivers.Average(d => d.DrivingHours),
                // Add any other stats you need...
            };

            return stats;
        }
    }
}
