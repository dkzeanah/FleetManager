using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ICheckListItemRepository
    {
        Task AddAsync(CheckListItem checkListItem);
        //Task DeleteAsync(CheckListItem checkListItem);
        Task DeleteByIdAsync(int checkListItemId);
        Task<List<CheckListItem>> GetAllAsync();
        Task<List<CheckListItem>> GetAllAsync(CancellationToken cancellationToken);
        Task<List<CheckListItem>> GetByCarIdAsync(int carId);
        Task<IEnumerable<CheckListItem>> GetByCompletionStatusAsync(bool isCompleted);
        Task<CheckListItem> GetByIdAsync(int checkListItemId);
        Task<IEnumerable<CheckListItem>> GetByPriorityAsync(PriorityLevel priority);
        Task<IEnumerable<CheckListItem>> GetByTestReleaseIdAsync(int testReleaseId);
        Task<IEnumerable<CheckListItem>> SearchAsync(string searchTerm);
        Task UpdateAsync(CheckListItem checkListItem);
        // Add other necessary methods
    }

}
