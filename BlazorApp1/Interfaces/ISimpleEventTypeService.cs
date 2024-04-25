using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ISimpleEventTypeService
    {
        Task<IEnumerable<SimpleEventType>> GetSimpleEventTypesAsync();
        Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id);
        Task AddSimpleEventTypeAsync(SimpleEventType simpleEventType);
        Task UpdateSimpleEventTypeAsync(SimpleEventType simpleEventType);
        Task DeleteSimpleEventTypeAsync(int id);
    }
}