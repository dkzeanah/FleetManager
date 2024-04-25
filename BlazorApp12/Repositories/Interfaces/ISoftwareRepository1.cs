using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface ISoftwareRepository1
    {
        Task AddSoftwareAsync(Software software);
        Task DeleteSoftwareAsync(int id);
        Task<List<Software>> GetAllSoftwareAsync();
        Task<Software> GetSoftwareByIdAsync(int id);
        Task UpdateSoftwareAsync(Software software);
    }
}