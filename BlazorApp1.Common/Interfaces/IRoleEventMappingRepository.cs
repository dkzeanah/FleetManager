using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IRoleEventMappingRepository
    {
        Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync();
        Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping);
    }
}
