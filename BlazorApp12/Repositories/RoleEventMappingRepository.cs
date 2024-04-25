using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class RoleEventMappingRepository : IRoleEventMappingRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleEventMappingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            return await _context.RoleEventMappings.ToListAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            _context.RoleEventMappings.Update(roleEventMapping);
            await _context.SaveChangesAsync();
        }
    }
}
