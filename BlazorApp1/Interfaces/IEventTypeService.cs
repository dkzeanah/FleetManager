using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IEventTypeService
    {
        Task<IEnumerable<EventType>> GetEventTypesAsync();
        Task<EventType> GetEventTypeByIdAsync(int id);
        Task AddEventTypeAsync(EventType eventType);
        Task UpdateEventTypeAsync(EventType eventType);
        Task DeleteEventTypeAsync(int id);
    }
}