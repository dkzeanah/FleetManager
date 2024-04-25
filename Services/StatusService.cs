using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public async Task<Status> GetStatusByIdAsync(int id)
        {
            return await _statusRepository.GetStatusByIdAsync(id);
        }

        public async Task<List<Status>> GetAllStatusAsync()
        {
            return await _statusRepository.GetAllStatusAsync();
        }

        public async Task AddStatusAsync(Status status)
        {
            await _statusRepository.AddStatusAsync(status);
        }

        public async Task UpdateStatusAsync(Status status)
        {
            await _statusRepository.UpdateStatusAsync(status);
        }

        public async Task DeleteStatusAsync(int id)
        {
            await _statusRepository.DeleteStatusAsync(id);
        }
    }
}
