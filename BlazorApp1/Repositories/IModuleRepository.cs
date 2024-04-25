
using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface IModuleRepository
    {
        Task<List<Module>> GetAllAsync();
        Task<List<Module>> GetModulesByCarIdAsync(int carId);

        Task<Module> GetByIdAsync(int id);
        Task AddAsync(Module item);
        Task UpdateAsync(int id, Module module);
        Task DeleteAsync(int id);
    }

   
}