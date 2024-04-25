using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ILoggerRepository
    {
        Task<List<Logger>> GetLoggerByCarIdAsync(int carId);
        Task<List<Logger>> GetAllLoggersAsync();
        Task AddLoggerAsync(Logger logger);
        Task UpdateLoggerAsync(Logger logger);
        Task DeleteLoggerAsync(int id);
        Task<Logger> GetLoggerByIdAsync(int id);
    }
}
