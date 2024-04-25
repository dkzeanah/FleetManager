using BlazorApp1.CarModels;
using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.Services
{
    public interface IUserCarEventService
    {
        Task<UserCarEvent> AddUserCarEventAsync(UserCarEvent newEvent);
        Task<UserCarEvent> GetUserCarEventByIdAsync(int id);
        //Task<List<UserCarEvent>> GetAllEventsByUserIdAsync(string userId);
        Task<CarModels.EventType> GetEventTypeByIdAsync(int id);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId);
        Task<List<UserCarEvent>> GetAllUserCarEventsByUserIdAsync(string userId);
        Task<int> GetDefaultEventTypeIdForRoleAsync(string role);
        Task CreateUserCarEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string role);
    }
}
