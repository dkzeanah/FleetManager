using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface ITaskModelRepository
    {
        Task<List<TaskModel>> GetAllTaskModelsAsync();
        Task<TaskModel> GetTaskModelByIdAsync(int id);
        Task AddTaskModelAsync(TaskModel task);
        Task UpdateTaskModelAsync(TaskModel task);
        Task DeleteTaskModelAsync(int id);
    }
}
