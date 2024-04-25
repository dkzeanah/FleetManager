using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IModuleService
    {
        Task<List<Module>> GetAllModulesAsync();
        Task<List<Module>> GetModulesByCarIdAsync(int carId);
        Task<Module> GetModuleByIdAsync(int id);
        Task AddModuleAsync(Module module);
        Task UpdateModuleAsync(int id, Module module);
        Task DeleteModuleAsync(int id);
    }
}