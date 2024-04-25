using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IErrorLogRepository
    {
        Task<ErrorLog> GetErrorLogByIdAsync(int id);
        // Add other methods for CRUD operations on ErrorLog
    }

}
