using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;

        public EventTypeService(IEventTypeRepository eventTypeRepository)
        {
            _eventTypeRepository = eventTypeRepository;
        }

        public async Task<IEnumerable<EventType>> GetEventTypesAsync()
        {
            return await _eventTypeRepository.GetAllEventTypesAsync();
        }

        public async Task<EventType> GetEventTypeByIdAsync(int id)
        {
            return await _eventTypeRepository.GetEventTypeByIdAsync(id);
        }

        public async Task AddEventTypeAsync(EventType eventType)
        {
            await _eventTypeRepository.AddEventTypeAsync(eventType);
        }

        public async Task UpdateEventTypeAsync(EventType eventType)
        {
            await _eventTypeRepository.UpdateEventTypeAsync(eventType);
        }

        public async Task DeleteEventTypeAsync(int id)
        {
            await _eventTypeRepository.DeleteEventTypeAsync(id);
        }
    }
}
