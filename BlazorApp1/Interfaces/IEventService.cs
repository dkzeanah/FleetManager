using BlazorApp1.CarModels;
using Microsoft.SqlServer.Management.Smo;
using EventType = BlazorApp1.CarModels.EventType;

namespace BlazorApp1.Interfaces
{
    public interface IEventService
    {

        Task UpdateEventAsync(Event eventType);
        Task DeleteEventAsync(int id); 
        Task<Event> AddEventAsync(Event newEvent);
        Task<Event> GetEventByIdAsync(int id);
        //Task<List<Event>> GetAllEventsByUserIdAsync(string userId);
        Task<SimpleEventType> GetEventTypeByIdAsync(int id);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId);
        Task<List<Event>> GetAllEventsByUserIdAsync(string userId);
        //
        //Task<List<Event>> GetAllEventsByUserIdAsync(string userId);
        Task<int> GetDefaultEventTypeIdForRoleAsync(string role);
        Task CreateCarEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string role);
        //EventTypes
        Task<IEnumerable<EventType>> GetAllEventTypesAsync();
        // Task<EventType> GetEventTypeByIdAsync(int id);
        Task AddEventTypeAsync(EventType eventType);
        Task UpdateEventTypeAsync(EventType eventType);
        Task DeleteEventTypeAsync(int id);
        Task<IEnumerable<EventType>> GetEventTypesAsync();
        Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync();
        Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping);
        Task AddRoleEventMappingAsync(RoleEventMapping roleEventMapping);

    }
}
