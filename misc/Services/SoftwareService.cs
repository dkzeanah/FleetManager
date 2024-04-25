using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Services
{
    public class SoftwareService : ISoftwareService
    {
        private readonly ISoftwareRepository _softwareRepository;

        public SoftwareService(ISoftwareRepository softwareRepository)
        {
            _softwareRepository = softwareRepository;
        }

        public async Task<Software> GetSoftwareByIdAsync(int id)
        {
            return await _softwareRepository.GetSoftwareByIdAsync(id);
        }

        public async Task<List<Software>> GetAllSoftwareAsync()
        {
            return await _softwareRepository.GetAllSoftwareAsync();
        }

        public async Task AddSoftwareAsync(Software software)
        {
            await _softwareRepository.AddSoftwareAsync(software);
        }

        public async Task UpdateSoftwareAsync(Software software)
        {
            await _softwareRepository.UpdateSoftwareAsync(software);
        }

        public async Task DeleteSoftwareAsync(int id)
        {
            await _softwareRepository.DeleteSoftwareAsync(id);
        }
    }
}
