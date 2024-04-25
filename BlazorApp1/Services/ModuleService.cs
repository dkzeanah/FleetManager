

using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;
using BlazorApp1.Migrations;
using BlazorApp1.Repositories;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using Humanizer;

namespace BlazorApp1.Services
{
    public class ModuleService : IModuleService
    {
        private readonly IModuleRepository _moduleRepository;
        private readonly ILogger<ModuleService> _logger; // Add a logger field


        public ModuleService(IModuleRepository ModuleRepository, ILogger<ModuleService> logger)
        {
            _moduleRepository = ModuleRepository;
            _logger = logger;
        }

        public async Task<List<Module>> GetAllModulesAsync()
        {
            return (await _moduleRepository.GetAllAsync()).ToList();
        }
        public async Task<List<Module>> GetModulesByCarIdAsync(int carId)
        {
            return await _moduleRepository.GetModulesByCarIdAsync(carId);
        }
        // Now, inside AddModuleComponent, the list ExistingModules will already be the filtered list that belongs to the selected car, and your loop that generates the UI for modules will function as intended, showing only the modules related to the selected car.






        public async Task<Module> GetModuleByIdAsync(int id)
        {
            return await _moduleRepository.GetByIdAsync(id);
        }
        public async Task AddModuleAsync(Module item)
        {
            try
            {
                await _moduleRepository.AddAsync(item);
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                _logger.LogError(ex, "Error occurred while adding a module.");
                throw; // Rethrow the exception to propagate it to the caller
            }
            /*            await _moduleRepository.AddAsync(item);
            */
        }
        public async Task UpdateModuleAsync(int id, Module module)
        {
            await _moduleRepository.UpdateAsync(id, module);
        }
        public async Task UpdateModuleAsync(Module module)
        {
            var id = module.ModuleId;
            await _moduleRepository.UpdateAsync(id, module);
        }
        public async Task DeleteModuleAsync(int id)
        {
             await _moduleRepository.DeleteAsync(id);
        }
    }
}