using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BlazorApp1.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        //private readonly ApplicationDbContext context;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public UserRepository(/*ApplicationDbContext context, */ IDbContextFactory<ApplicationDbContext> contextFactory, AuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;

            _contextFactory = contextFactory;

            //context = context;
        }

        public async Task AddUserAsync(ApplicationUser user)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Users.Add(user);
            await context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                context.Users.Remove(user);
                await context.SaveChangesAsync();
            }
        }

        public Task SaveChangesAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            throw new NotImplementedException();
        }

        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        }

        public async Task<ApplicationUser> GetUserDetail(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            // Assumes ApplicationUser has ApplicationUserDetail navigation property
            return await context.Users.Include(u => u.ApplicationUserDetail)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task UpdateUserAsync(ApplicationUser user)
        {
            using var context = _contextFactory.CreateDbContext();

            var existingUser = await context.Users.FirstOrDefaultAsync(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Email = user.Email;
                // Add any other property updates here as needed
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<ApplicationUser>> GetAllUsersWithDetailsAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            // Assumes ApplicationUser has ApplicationUserDetail navigation property
            return await context.Users.Include(u => u.ApplicationUserDetail).ToListAsync();
        }

        public async Task UpdateUserDetailAsync(ApplicationUserDetail userDetail)
        {
            using var context = _contextFactory.CreateDbContext();

            // Here you would need to write code to update ApplicationUserDetail in your database
            // The exact implementation depends on how you've set up your DbContext and database
            // Following is a rough example

            var user = await context.Users.Include(u => u.ApplicationUserDetail)
                .FirstOrDefaultAsync(u => u.ApplicationUserDetail.UserId == userDetail.UserId);

            if (user != null)
            {
                user.ApplicationUserDetail = userDetail;
                await context.SaveChangesAsync();
            }
        }
        public async Task UpdateUserDetailAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            // Here you would need to write code to update ApplicationUserDetail in your database
            // The exact implementation depends on how you've set up your DbContext and database
            // Following is a rough example

            var user = await context.Users.Include(u => u.ApplicationUserDetail)
                .FirstOrDefaultAsync(u => u.ApplicationUserDetail.UserId == userId);

            if (user != null)
            {
                user.ApplicationUserDetail = user.ApplicationUserDetail;
                await context.SaveChangesAsync();
            }
        }

        public async Task<string> GetCurrentUserIdAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var username = authState.User.Identity.Name; // This should give you the username of the logged-in user

            var user = await context.Users.FirstOrDefaultAsync(u => u.UserName == username); // assuming UserName is the property in your User entity
            return user?.Id;
        }
        /*public async Task<string> GetCurrentUserIdAsync()
        {
            return (await context.Users.FirstOrDefaultAsync()).Id;
        }*/
    }
}
