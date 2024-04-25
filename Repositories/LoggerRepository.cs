using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class LoggerRepository : ILoggerRepository
    {
        private readonly ApplicationDbContext _context;

        public LoggerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Logger> GetLoggerByIdAsync(int id)
        {
            return await _context.Loggers.FindAsync(id);
        }

        public async Task<List<Logger>> GetAllLoggerAsync()
        {
            return await _context.Loggers.ToListAsync();
        }

        public async Task AddLoggerAsync(Logger logger)
        {
            _context.Loggers.Add(logger);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLoggerAsync(Logger logger)
        {
            _context.Loggers.Update(logger);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLoggerAsync(int id)
        {
            var logger = await _context.Loggers.FindAsync(id);
            _context.Loggers.Remove(logger);
            await _context.SaveChangesAsync();
        }
    }

}
