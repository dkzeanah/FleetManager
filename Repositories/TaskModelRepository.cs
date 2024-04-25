using BlazorApp1.CarModels;
using BlazorApp1.Data;
using System.Data.Entity;

namespace BlazorApp1.Repositories
{
    public class TaskModelRepository : ITaskModelRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskModelRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskModel>> GetAllTaskModelsAsync()
        {
            return await _context.TaskModels.ToListAsync();
        }

        public async Task<TaskModel> GetTaskModelByIdAsync(int id)
        {
            return await _context.TaskModels.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task AddTaskModelAsync(TaskModel taskModel)
        {
            _context.TaskModels.Add(taskModel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskModelAsync(TaskModel taskModel)
        {
            _context.Entry(taskModel).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskModelAsync(int id)
        {
            var taskModel = await _context.TaskModels.FindAsync(id);
            if (taskModel != null)
            {
                _context.TaskModels.Remove(taskModel);
                await _context.SaveChangesAsync();
            }
        }
    }
}
