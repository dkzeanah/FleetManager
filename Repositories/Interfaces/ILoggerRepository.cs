using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ILoggerRepository
    {
        Task<Logger> GetLoggerByIdAsync(int id);
        Task<List<Logger>> GetAllLoggerAsync();
        Task AddLoggerAsync(Logger logger);
        Task UpdateLoggerAsync(Logger logger);
        Task DeleteLoggerAsync(int id);
    }
}
