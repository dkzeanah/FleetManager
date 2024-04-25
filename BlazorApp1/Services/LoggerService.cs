using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;
using BlazorApp1.Repositories;

namespace BlazorApp1.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILoggerRepository _loggerRepository;

        public LoggerService(ILoggerRepository loggerRepository)
        {
            _loggerRepository = loggerRepository;
        }

        public async Task<Logger> GetLoggerByIdAsync(int id)
        {
            return await _loggerRepository.GetLoggerByIdAsync(id);
        }
        public async Task<List<Logger>> GetLoggersByCarIdAsync(int carId)
        {
            return await _loggerRepository.GetLoggersByCarIdAsync(carId);
        }


        public async Task<List<Logger>> GetAllLoggerAsync()
        {
            return await _loggerRepository.GetAllLoggersAsync();
        }

        public async Task AddLoggerAsync(Logger logger)
        {
            await _loggerRepository.AddLoggerAsync(logger);
        }

        public async Task UpdateLoggerAsync(Logger logger)
        {
            await _loggerRepository.UpdateLoggerAsync(logger);
        }

        public async Task DeleteLoggerAsync(int id)
        {
            await _loggerRepository.DeleteLoggerAsync(id);
        }
    }
}
