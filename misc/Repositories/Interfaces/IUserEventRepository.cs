using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserEventRepository
    {
        Task<UserEventDetail> GetUserEventDByIdAsync(int id);
        Task<IEnumerable<UserEventDetail>> GetAllUserEventsAsync();
        Task AddUserEventAsync(UserEventDetail userEventDetail);
        Task UpdateUserEventAsync(UserEventDetail userEventDetail);
        Task DeleteUserEventAsync(int id);
    }
}
