using BlazorApp1.CarModels;
using System;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetEventByIdAsync(int EventId);
        Task<List<Event>> GetAllEventsByEventTypeAsync(int eventTypeId);
        Task<List<Event>> GetAllEventsByUserIdAsync(string userId); //List would be a more common return type when the data set is finite and needs further processing or manipulation.
        //Task<IEnumerable<Event>> GetAllEventsByUserId(string userId); //Gippity//For example, if you often need to retrieve all events for a specific user,

        Task<Event> AddEventAsync(Event newEvent);

        Task<bool> IsCarAvailable(int carId, DateTime startTime, DateTime endTime, int eventTypeId);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId);
        CarModels.UserTask UpdateEventTypeAsync(EventType eventType);
        Task<Event> GetLatestEventByUserIdAsync(string userId);
    }

}
