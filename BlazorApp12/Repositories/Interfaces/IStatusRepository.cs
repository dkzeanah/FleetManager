using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IStatusRepository
    {
        Task AddStatusAsync(Status status);
        Task DeleteStatusAsync(int id);
        Task<List<Status>> GetAllStatusAsync();
        Task<Status> GetStatusByIdAsync(int id);
        Task UpdateStatusAsync(Status status);
    }
}
