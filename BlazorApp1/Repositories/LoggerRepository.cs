using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class LoggerRepository : ILoggerRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        //private readonly ApplicationDbContext context;

        public LoggerRepository(/*ApplicationDbContext context*/ IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;

            //context = context;
        }

        public async Task<List<Logger>> GetLoggersByCarIdAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Loggers.Where(m => m.CarId == carId).ToListAsync();

            // return await context.Loggers.FindAsync(id);
        }

        public async Task<List<Logger>> GetAllLoggersAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Loggers.ToListAsync();
        }

        public async Task AddLoggerAsync(Logger logger)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Loggers.Add(logger);
            await context.SaveChangesAsync();
        }

        public async Task UpdateLoggerAsync(Logger logger)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Loggers.Update(logger);
            await context.SaveChangesAsync();
        }

        public async Task DeleteLoggerAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var logger = await context.Loggers.FindAsync(id);
            context.Loggers.Remove(logger);
            await context.SaveChangesAsync();
        }

        public async Task<Logger> GetLoggerByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Loggers.FindAsync(id);
        }
    }

}
