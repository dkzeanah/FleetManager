using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class SimpleEventTypeService : ISimpleEventTypeService
    {
        private readonly ISimpleEventTypeRepository _simpleEventTypeRepository;

        public SimpleEventTypeService(ISimpleEventTypeRepository simpleEventTypeRepository)
        {
            _simpleEventTypeRepository = simpleEventTypeRepository;
        }

        public async Task<IEnumerable<SimpleEventType>> GetSimpleEventTypesAsync()
        {
            return await _simpleEventTypeRepository.GetAllSimpleEventTypesAsync();
        }

        public async Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id)
        {
            return await _simpleEventTypeRepository.GetSimpleEventTypeByIdAsync(id);
        }

        public async Task AddSimpleEventTypeAsync(SimpleEventType eventType)
        {
            await _simpleEventTypeRepository.AddSimpleEventTypeAsync(eventType);
        }

        public async Task UpdateSimpleEventTypeAsync(SimpleEventType eventType)
        {
            await _simpleEventTypeRepository.UpdateSimpleEventTypeAsync(eventType);
        }

        public async Task DeleteSimpleEventTypeAsync(int id)
        {
            await _simpleEventTypeRepository.DeleteSimpleEventTypeAsync(id);
        }
    }
}
