using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ISoftwareService
    {
        Task AddSoftwareAsync(Software software);
        Task DeleteSoftwareAsync(int id);
        Task<List<Software>> GetAllSoftwareAsync();
        Task<Software> GetSoftwareByIdAsync(int id);
        Task UpdateSoftwareAsync(Software software);
    }
}