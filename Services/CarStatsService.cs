using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class CarStatsService : IStatsService<Car, CarStats>
    {
        //private ApplicationDbContext _ApplicationDbContext;
        private readonly ApplicationDbContext _ApplicationDbContext;

        public CarStatsService(ApplicationDbContext context)
        {
            _ApplicationDbContext = context;
        }
        /*public CarStatsService(IDbContext context)
        {
            _MockDbContext = (MockDbContext?)context;
        }*/

        public async Task<CarStats> GetStatsAsync()
        {
            var cars = await _ApplicationDbContext.Cars.ToListAsync();

            var stats = new CarStats
            {
                TotalCount = cars.Count,
                AverageMileage = (double)cars.Average(c => c.Miles),
                // Add any other stats you need...
            };

            return stats;
        }
    }
}
