using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels 
{ 
    public class TaskModel
    {
        public int Id { get; set; }
        public DateTime DateAssigned { get; set; } = DateTime.Now;
        [Required]
        public string Task { get; set; }
        public bool IsComplete { get; set; } = false;


        public virtual ApplicationUser? User { get; set; }// = null!;

        public string? UserId { get; set; }
        public string? UserName { get; set; }

        public int? Importance { get; set; }

        public DateTime? DateCompleted { get; set; }
        public DateTime? DateExpired { get; set; }
    }
    /*public interface ITaskModelRepository
    {
        Task<IEnumerable<TaskModel>> GetAllTaskModelsAsync();
        Task<TaskModel> GetTaskModelByIdAsync(int id);
        Task AddTaskModelAsync(TaskModel task);
        Task UpdateTaskModelAsync(TaskModel task);
        Task DeleteTaskModelAsync(int id);
    }*/
}
