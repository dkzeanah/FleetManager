using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ILoggerService
    {
        Task<Logger> GetLoggerByIdAsync(int id);
        Task<List<Logger>> GetLoggersByCarIdAsync(int carId);
        Task<List<Logger>> GetAllLoggerAsync();
        Task AddLoggerAsync(Logger logger);
        Task UpdateLoggerAsync(Logger logger);
        Task DeleteLoggerAsync(int id);
    }
}
