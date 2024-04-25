using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IEventTypeRepository
    {
        Task<IEnumerable<EventType>> GetAllEventTypesAsync();
        Task<EventType> GetEventTypeByIdAsync(int id);
        Task AddEventTypeAsync(EventType eventType);
        Task UpdateEventTypeAsync(EventType eventType);
        Task DeleteEventTypeAsync(int id);
        Task<IEnumerable<EventType>> GetEventTypesAsync();
    }
}
