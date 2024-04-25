using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class TaskModelService : ITaskModelService
    {
        private readonly ITaskModelRepository _taskModelRepository;



        public TaskModelService(ITaskModelRepository taskModelRepository)
        {
            _taskModelRepository = taskModelRepository;
        }
        public async Task<List<TaskModel>> GetAllTaskModelsByUserIdAsync(string userId)
        {
            return (await _taskModelRepository.GetAllTaskModelsByUserIdAsync(userId)).ToList();
        }

        public async Task<List<TaskModel>> GetAllTaskModels()
        {
            return (await _taskModelRepository.GetAllTaskModelsAsync()).ToList();
        }

        public async Task<TaskModel> GetTaskModel(int id)
        {
            return await _taskModelRepository.GetTaskModelByIdAsync(id);
        }

        public async Task AddTaskModel(TaskModel taskModel)
        {
             await _taskModelRepository.AddTaskModelAsync(taskModel);
        }

        public async Task UpdateTaskModel(TaskModel taskModel)
        {
             await _taskModelRepository.UpdateTaskModelAsync(taskModel);
        }

        public async Task DeleteTaskModel(int id)
        {
             await _taskModelRepository.DeleteTaskModelAsync(id);
        }

        /*
            public class TaskInfo
            {
                public string TaskName { get; set; }
                public string Information { get; set; }
                public DateTime DateAssigned { get; set; }
                public DateTime DateDue { get; set; }
                // Add more fields as required
            }
        */
        public Task<List<TaskInfo>> GetAllTaskInfosByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskInfo>> GetAllTaskInfos()
        {
            throw new NotImplementedException();
        }

        public Task<TaskInfo> GetTaskInfos(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddTaskInfos(TaskInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTaskInfos(TaskInfo entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTaskInfos(int id)
        {
            throw new NotImplementedException();
        }

    public Task AddTaskModelAsync(TaskModel entity)
    {
      throw new NotImplementedException();
    }
    // Implement other methods as required
  }
}

