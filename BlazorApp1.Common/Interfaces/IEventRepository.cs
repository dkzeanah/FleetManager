using BlazorApp1.CarModels;
using System;

namespace BlazorApp1.Interfaces
{
    public interface IEventRepository
    {

        Task<Event> GetEventByIdAsync(int EventId);
        Task<List<Event>> GetAllEventsByEventTypeAsync(int simpleEventTypeId);
        Task<List<Event>> GetAllEventsByUserIdAsync(string userId); //List would be a more common return type when the data set is finite and needs further processing or manipulation.
        //Task<IEnumerable<Event>> GetAllEventsByUserId(string userId); //Gippity//For example, if you often need to retrieve all events for a specific user,

        Task<Event> AddEventAsync(Event newEvent);

        //you could add a method like this to IEventRepository:
        // Task<bool> IsCarAvailable(int carId, DateTime startTime, DateTime endTime);

        // Task<bool> IsCarAvailable(int carId, DateTime startTime, DateTime endTime, int simpleEventTypeId);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int simpleEventTypeId);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime);

        Task UpdateEventTypeAsync(EventType eventType);
        Task UpdateSimpleEventTypeAsync(SimpleEventType simpleEventType);
        Task<Event> GetLatestEventByUserIdAsync(string userId);
        Task<int> GetDefaultEventTypeIdForRoleAsync(string role);
        Task DeleteEventAsync(int id);
        Task UpdateEventAsync(Event newEvent);
    }

}
