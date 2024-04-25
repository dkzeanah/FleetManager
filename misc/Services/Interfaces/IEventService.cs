using BlazorApp1.CarModels;
using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.Services
{
    public interface IEventService
    {
        Task<Event> AddEventAsync(Event newEvent);
        Task<Event> GetEventByIdAsync(int id);
        //Task<List<Event>> GetAllEventsByUserIdAsync(string userId);
        Task<CarModels.EventType> GetEventTypeByIdAsync(int id);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId);
        Task<List<Event>> GetAllEventsByUserIdAsync(string userId);
        Task<int> GetDefaultEventTypeIdForRoleAsync(string role);
        Task CreateCarEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string role);
    }
}
