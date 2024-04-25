
using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Migrations;
using DocumentFormat.OpenXml.Wordprocessing;
using Humanizer;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;

namespace BlazorApp1.Repositories

{
    public class ModuleRepository : IModuleRepository
    {
        // private readonly ApplicationDbContext _context;
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        private readonly ILogger<ModuleRepository> _logger;


        public ModuleRepository(IDbContextFactory<ApplicationDbContext> contextFactory, ILogger<ModuleRepository> logger)
        {
            _contextFactory = contextFactory;
            _logger = logger;
        }
        public async Task<List<Module>> GetModulesByCarIdAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();

            // Assuming you have a DbContext and Modules have a CarId property
            return await context.Modules.Where(m => m.CarId == carId).ToListAsync();
        }
        //Now, inside AddModuleComponent, the list ExistingModules will already be the filtered list that belongs to the selected car, and your loop that generates the UI for modules will function as intended, showing only the modules related to the selected car.


        public async Task<List<Module>?> GetModuleByCarIdAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Modules
                     .Where(m => m.CarId == carId)
                     .ToListAsync();


        }
        public async Task<List<Module>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Modules.ToListAsync();
        }

        public async Task<Module> GetByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Modules.FindAsync(id);
        }

        public async Task AddAsync(Module item)
        {
            using var context = _contextFactory.CreateDbContext();

            try
            {
                context.Modules.Add(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                _logger.LogError(ex, "Error occurred while adding a module.");
                throw; // Rethrow the exception to propagate it to the caller
            }
            /*            context.Modules.Add(item);
                        await context.SaveChangesAsync();*/
        }

        public async Task UpdateAsync(int id, Module module)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Modules.Update(module);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var module = await context.Modules.FindAsync(id);
            if (module != null)
            {
                context.Modules.Remove(module);
                await context.SaveChangesAsync();
            }
        }
    }
}