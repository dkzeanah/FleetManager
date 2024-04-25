using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserEventRepository
    {
        Task<UserEvent> GetUserEventDByIdAsync(int id);
        Task<IEnumerable<UserEvent>> GetAllUserEventsAsync();
        Task AddUserEventAsync(UserEvent userEvent);
        Task UpdateUserEventAsync(UserEvent userEvent);
        Task DeleteUserEventAsync(int id);
    }
}
