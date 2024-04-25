using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace BlazorApp1.Repositories
{
    public class CheckListItemRepository : ICheckListItemRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        private readonly ILogger<CheckListItemRepository> _logger;


        public CheckListItemRepository(IDbContextFactory<ApplicationDbContext> contextFactory, ILogger<CheckListItemRepository> logger)
        {
            _contextFactory = contextFactory;
            _logger = logger;
        }

        public async Task AddAsync(CheckListItem checkListItem)
        {
            using var context = _contextFactory.CreateDbContext();
            try
            {
                context.CheckListItems.Add(checkListItem);
                await context.SaveChangesAsync();
                _logger.LogInformation("Added CheckListItem with ID: {CheckListItemId}", checkListItem.Id);

            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "Error adding CheckListItem");
                throw;
            }
        }

        public async Task DeleteByIdAsync(int checkListItemId)
        {
            using var context = _contextFactory.CreateDbContext();
            try
            {
                var item = await context.CheckListItems.FindAsync(checkListItemId);
                if (item != null)
                {
                    Console.WriteLine($"{item.Id} IsDeleted is true");
                    item.IsDeleted = true; // Mark as deleted instead of removing
                                           // Optionally, set a DeletedAt timestamp if you have such a field
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                throw;
            }
        }

        public async Task<List<CheckListItem>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => !c.IsDeleted).ToListAsync();
        }

        public async Task<List<CheckListItem>> GetAllAsync(CancellationToken cancellationToken)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => !c.IsDeleted).ToListAsync(cancellationToken);
        }

        public async Task<List<CheckListItem>> GetByCarIdAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => c.CarId == carId && !c.IsDeleted).ToListAsync();
        }

        public async Task<IEnumerable<CheckListItem>> GetByCompletionStatusAsync(bool isCompleted)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => c.IsCompleted == isCompleted).ToListAsync();
        }



        public async Task<IEnumerable<CheckListItem>> GetByPriorityAsync(PriorityLevel priority)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => c.Priority == priority).ToListAsync();
        }

        public async Task<IEnumerable<CheckListItem>> GetByTestReleaseIdAsync(int testReleaseId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems.Where(c => c.TestReleaseId == testReleaseId).ToListAsync();
        }

        public async Task<IEnumerable<CheckListItem>> SearchAsync(string searchTerm)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems
                .Where(c => c.Title.Contains(searchTerm) || c.Description.Contains(searchTerm))
                .ToListAsync();
        }
        public async Task<CheckListItem> GetByIdAsync(int checkListItemId)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CheckListItems
                                .FirstOrDefaultAsync(c => c.Id == checkListItemId && !c.IsDeleted);
        }

        public async Task UpdateAsync(CheckListItem checkListItem)
        {
            using var context = _contextFactory.CreateDbContext();
            context.CheckListItems.Update(checkListItem);
            await context.SaveChangesAsync();
        }

    }
}
