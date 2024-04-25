using BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    public interface IStatusService
    {
        Task AddStatusAsync(Status status);
        Task DeleteStatusAsync(int id);
        Task<List<Status>> GetAllStatusAsync();
        Task<Status> GetStatusByIdAsync(int id);
        Task UpdateStatusAsync(Status status);
    }
}