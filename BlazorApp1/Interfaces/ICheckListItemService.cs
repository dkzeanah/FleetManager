using BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    public interface ICheckListItemService
    {
        Task<CheckListItem> GetCheckListItemByIdAsync(int checkListItemId);

        Task<List<CheckListItem>> GetAllCheckListItemsAsync();
        Task<List<CheckListItem>> GetAllCheckListItemsAsync(CancellationToken cancellationToken);
        Task AddCheckListItemAsync(CheckListItem checkListItem);
        Task UpdateCheckListItemAsync(CheckListItem checkListItem);
        Task DeleteCheckListItemAsync(int checkListItemId);
        Task DeleteCheckListItemAsync(CheckListItem checkListItem);

        // Search/Filter functionality

        // Get checklist items by car ID
        Task<IEnumerable<CheckListItem>> GetCheckListItemsByCarIdAsync(int carId);

        // Get checklist items by completion status
        Task<IEnumerable<CheckListItem>> GetCheckListItemsByCompletionStatusAsync(bool isCompleted);

        // Get checklist items by priority level
        Task<IEnumerable<CheckListItem>> GetCheckListItemsByPriorityAsync(PriorityLevel priority);

        // Get checklist items by test release ID
        Task<IEnumerable<CheckListItem>> GetCheckListItemsByTestReleaseIdAsync(int testReleaseId);

        // Search checklist items by title or description
        Task<IEnumerable<CheckListItem>> SearchCheckListItemsAsync(string searchTerm);


    }
}