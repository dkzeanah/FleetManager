using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.Repositories
{
    public class UserEventRepository : IUserEventRepository
    {
        private readonly ApplicationDbContext _context;

        public UserEventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserEvent> GetUserEventDByIdAsync(int id)
        {
            return await _context.UserEvents.FindAsync(id);
        }

        public async Task<IEnumerable<UserEvent>> GetAllUserEventsAsync()
        {
            return await _context.UserEvents.ToListAsync();
        }

        public async Task AddUserEventAsync(UserEvent userEvent)
        {
            _context.UserEvents.Add(userEvent);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserEventAsync(UserEvent userEventDetail)
        {
            _context.Entry(userEventDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserEventAsync(int id)
        {
            var userEventDetail = await _context.UserEvents.FindAsync(id);
            if (userEventDetail != null)
            {
                _context.UserEvents.Remove(userEventDetail);
                await _context.SaveChangesAsync();
            }
        }
    }
}
