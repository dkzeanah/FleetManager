using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IEventTypeRepository
    {
        Task<IEnumerable<EventType>> GetAllEventTypesAsync();
        Task<EventType> GetEventTypeByIdAsync(int id);
        Task AddEventTypeAsync(EventType eventType);
        Task UpdateEventTypeAsync(EventType eventType);
        Task DeleteEventTypeAsync(int id);
        Task<IEnumerable<EventType>> GetEventTypesAsync();
        Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync();
        Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping);
    }
}
