using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ITaskModelService
    {
        Task AddTaskModelAsync(TaskModel entity);
        Task<List<TaskModel>> GetAllTaskModelsByUserIdAsync(string userId);
        Task<List<TaskModel>> GetAllTaskModels();
        Task<TaskModel> GetTaskModel(int id);
        Task AddTaskModel(TaskModel entity);
        Task UpdateTaskModel(TaskModel entity);
        Task DeleteTaskModel(int id);

        Task<List<TaskInfo>> GetAllTaskInfosByUserIdAsync(string userId);
        Task<List<TaskInfo>> GetAllTaskInfos();
        Task<TaskInfo> GetTaskInfos(int id);
        Task AddTaskInfos(TaskInfo entity);
        Task UpdateTaskInfos(TaskInfo entity);
        Task DeleteTaskInfos(int id);
    }
}