using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ITaskModelRepository
    {
        Task<IEnumerable<TaskModel>> GetAllTaskModelsByUserIdAsync(string userId);

        //Task<IEnumerable<TaskModel>> GetAllTaskModelsByUserIdAsync(string userId);

        Task<IEnumerable<TaskModel>> GetAllTaskModelsAsync();
        Task<TaskModel> GetTaskModelByIdAsync(int id);
        Task AddTaskModelAsync(TaskModel task);
        Task UpdateTaskModelAsync(TaskModel task);
        Task DeleteTaskModelAsync(int id);
    }
}
