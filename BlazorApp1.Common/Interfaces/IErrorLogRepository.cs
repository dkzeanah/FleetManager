using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IErrorLogRepository
    {
        Task<ErrorLog> GetErrorLogByIdAsync(int id);
        // Add other methods for CRUD operations on ErrorLog
    }

}
