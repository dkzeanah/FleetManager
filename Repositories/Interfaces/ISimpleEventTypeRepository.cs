using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ISimpleEventTypeRepository
    {
        Task<IEnumerable<SimpleEventType>> GetAllSimpleEventTypesAsync();
        Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id);
        Task AddSimpleEventTypeAsync(SimpleEventType simpleEventType);
        Task UpdateSimpleEventTypeAsync(SimpleEventType simpleEventType);
        Task DeleteSimpleEventTypeAsync(int id);
        Task<IEnumerable<SimpleEventType>> GetSimpleEventTypesAsync();
    }
}
