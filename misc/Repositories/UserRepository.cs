using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BlazorApp1.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(ApplicationUser user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }

        public async Task<ApplicationUser> GetUserDetail(string userId)
        {
            // Assumes ApplicationUser has ApplicationUserDetail navigation property
            return await _context.Users.Include(u => u.UserDetails)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task UpdateUserAsync(ApplicationUser user)
        {
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Email = user.Email;
                // Add any other property updates here as needed
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<ApplicationUser>> GetAllUsersWithDetailsAsync()
        {
            // Assumes ApplicationUser has ApplicationUserDetail navigation property
            return await _context.Users.Include(u => u.UserDetails).ToListAsync();
        }

        public async Task UpdateUserDetailAsync(UserDetails userDetails)
        {
            // Here you would need to write code to update ApplicationUserDetail in your database
            // The exact implementation depends on how you've set up your DbContext and database
            // Following is a rough example

            var user = await _context.Users.Include(u => u.UserDetails)
                .FirstOrDefaultAsync(u => u.UserDetails.Id == userDetails.Id);

            if (user != null)
            {
                user.UserDetails = userDetails;
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateUserDetailsAsync(string userId)
        {
            // Here you would need to write code to update ApplicationUserDetail in your database
            // The exact implementation depends on how you've set up your DbContext and database
            // Following is a rough example

            var user = await _context.Users.Include(u => u.UserDetails)
                .FirstOrDefaultAsync(u => u.ApplicationUserDetail.UserId == userId);

            if (user != null)
            {
                user.ApplicationUserDetail = user.ApplicationUserDetail;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<string> GetCurrentUserIdAsync()
        {
            return (await _context.Users.FirstOrDefaultAsync()).Id;
        }
    }
}
