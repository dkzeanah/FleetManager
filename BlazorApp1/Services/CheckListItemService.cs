using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class CheckListItemService : ICheckListItemService
    {
        private readonly ICheckListItemRepository _checkListItemRepository;

        public CheckListItemService(ICheckListItemRepository checkListItemRepository)
        {
            _checkListItemRepository = checkListItemRepository;
        }

        public async Task<CheckListItem> GetCheckListItemByIdAsync(int checkListItemId)
        {
            return await _checkListItemRepository.GetByIdAsync(checkListItemId);
        }

        public async Task<List<CheckListItem>> GetAllCheckListItemsAsync()
        {
            return await _checkListItemRepository.GetAllAsync();
        }

        public async Task<List<CheckListItem>> GetAllCheckListItemsAsync(CancellationToken cancellationToken)
        {
            return await _checkListItemRepository.GetAllAsync(cancellationToken);
        }

        public async Task AddCheckListItemAsync(CheckListItem checkListItem)
        {
            await _checkListItemRepository.AddAsync(checkListItem);
        }

        public async Task UpdateCheckListItemAsync(CheckListItem checkListItem)
        {
            await _checkListItemRepository.UpdateAsync(checkListItem);
        }

        public async Task DeleteCheckListItemAsync(int checkListItemId)
        {
            await _checkListItemRepository.DeleteByIdAsync(checkListItemId);
        }

       /* public async Task DeleteCheckListItemAsync(CheckListItem checkListItem)
        {
            await _checkListItemRepository.DeleteByIdAsync(checkListItem);
        }*/

        public async Task<IEnumerable<CheckListItem>> GetCheckListItemsByCarIdAsync(int carId)
        {
            return await _checkListItemRepository.GetByCarIdAsync(carId);
        }

        public async Task<IEnumerable<CheckListItem>> GetCheckListItemsByCompletionStatusAsync(bool isCompleted)
        {
            return await _checkListItemRepository.GetByCompletionStatusAsync(isCompleted);
        }

        public async Task<IEnumerable<CheckListItem>> GetCheckListItemsByPriorityAsync(PriorityLevel priority)
        {
            return await _checkListItemRepository.GetByPriorityAsync(priority);
        }

        public async Task<IEnumerable<CheckListItem>> GetCheckListItemsByTestReleaseIdAsync(int testReleaseId)
        {
            return await _checkListItemRepository.GetByTestReleaseIdAsync(testReleaseId);
        }

        public async Task<IEnumerable<CheckListItem>> SearchCheckListItemsAsync(string searchTerm)
        {
            return await _checkListItemRepository.SearchAsync(searchTerm);
        }

        public Task DeleteCheckListItemAsync(CheckListItem checkListItem)
        {
            throw new NotImplementedException();
        }
    }

}
