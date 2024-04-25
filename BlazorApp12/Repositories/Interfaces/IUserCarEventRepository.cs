using BlazorApp1.CarModels;
using System;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserCarEventRepository
    {
        Task<UserCarEvent> GetEventByIdAsync(int EventId);
        Task<List<UserCarEvent>> GetAllEventsByEventTypeAsync(int eventTypeId);
        Task<List<UserCarEvent>> GetAllEventsByUserIdAsync(string userId); //List would be a more common return type when the data set is finite and needs further processing or manipulation.
        //Task<IEnumerable<UserCarEvent>> GetAllEventsByUserId(string userId); //Gippity//For example, if you often need to retrieve all events for a specific user,

        Task<UserCarEvent> AddUserCarEventAsync(UserCarEvent newEvent);

        Task<bool> IsCarAvailable(int carId, DateTime startTime, DateTime endTime, int eventTypeId);
        Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId);
        CarModels.UserTask UpdateEventTypeAsync(EventType eventType);
        Task<UserCarEvent> GetLatestUserCarEventByUserIdAsync(string userId);
        //Task AddUserCarEventAsync(UserCarEvent newUserCarEvent);
    }

}
