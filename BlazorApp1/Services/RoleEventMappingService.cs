using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class RoleEventMappingService : IRoleEventMappingService
    {
        private readonly IRoleEventMappingRepository _roleEventMappingRepository;

        public RoleEventMappingService(IRoleEventMappingRepository roleEventMappingRepository)
        {
            _roleEventMappingRepository = roleEventMappingRepository;

        }

        public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            return await _roleEventMappingRepository.GetRoleEventMappingsAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            await _roleEventMappingRepository.UpdateRoleEventMappingAsync(roleEventMapping);
        }
    }
}
