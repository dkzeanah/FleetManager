using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class UserEventRepository : IUserEventRepository
    {
        private readonly ApplicationDbContext _context;

        public UserEventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<UserEventDetail> GetUserEventDByIdAsync(int id)
        {
            return await _context.UserEventDetails.FindAsync(id);
        }

        public async Task<IEnumerable<UserEventDetail>> GetAllUserEventsAsync()
        {
            return await _context.UserEventDetails.ToListAsync();
        }

        public async Task AddUserEventAsync(UserEventDetail userEventDetail)
        {
            _context.UserEventDetails.Add(userEventDetail);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserEventAsync(UserEventDetail userEventDetail)
        {
            _context.Entry(userEventDetail).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserEventAsync(int id)
        {
            var userEventDetail = await _context.UserEventDetails.FindAsync(id);
            if (userEventDetail != null)
            {
                _context.UserEventDetails.Remove(userEventDetail);
                await _context.SaveChangesAsync();
            }
        }
    }
}
