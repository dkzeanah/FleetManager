using BlazorApp1.CarModels;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;

namespace BlazorApp1.Services
{
    public class EventTypeService : IEventTypeService
    {
        private readonly IEventTypeRepository _eventTypeRepository;
       // private readonly IRoleEventMappingRepository _roleEventMappingRepository;


        public EventTypeService(IEventTypeRepository eventTypeRepository) //, IRoleEventMappingRepository roleEventMappingRepository)
        {
            _eventTypeRepository = eventTypeRepository;
            //_roleEventMappingRepository = roleEventMappingRepository;

        }

        /*public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            return await _roleEventMappingRepository.GetRoleEventMappingsAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            await _roleEventMappingRepository.UpdateRoleEventMappingAsync(roleEventMapping);
        }*/
 
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
