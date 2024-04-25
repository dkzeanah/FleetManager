using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace BlazorApp1.Repositories
{
    public class TaskModelRepository : ITaskModelRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        public TaskModelRepository(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public async Task<IEnumerable<TaskModel>> GetAllTaskModelsByUserIdAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.TaskModels
                .Where(x => x.UserId == userId)
                .ToListAsync();
        }
        public async Task<IEnumerable<TaskModel>> GetAllTaskModelsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.TaskModels.ToListAsync();
        }

        public async Task<TaskModel> GetTaskModelByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.TaskModels.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task AddTaskModelAsync(TaskModel taskModel)
        {
            using var context = _contextFactory.CreateDbContext();

            context.TaskModels.Add(taskModel);
            await context.SaveChangesAsync();
        }

        public async Task UpdateTaskModelAsync(TaskModel taskModel)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Entry(taskModel).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteTaskModelAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            var taskModel = await context.TaskModels.FindAsync(id);
            if (taskModel != null)
            {
                context.TaskModels.Remove(taskModel);
                await context.SaveChangesAsync();
            }
        }
    }
}
