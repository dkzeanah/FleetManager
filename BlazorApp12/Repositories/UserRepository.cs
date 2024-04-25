using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Timeline = BlazorApp1.Pages.Timeline;

namespace BlazorApp1.Repositories
{


    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Methods for ApplicationUser

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

        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
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

        // Methods for ApplicationUserDetail

        public async Task<ApplicationUserDetail> GetApplicationUserDetailsAsync(string userId)
        {
            var user = await _context.Users.Include(u => u.ApplicationUserDetails)
                                            .FirstOrDefaultAsync(u => u.Id == userId);
            return (ApplicationUserDetail)(user?.ApplicationUserDetails);
        }

        public async Task UpdateApplicationUserDetailsAsync(string userId, ApplicationUserDetail updatedDetails)
        {
            var user = await _context.Users.Include(u => u.ApplicationUserDetails)
                                           .FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null && user.ApplicationUserDetails != null)
            {
                /*user.ApplicationUserDetails = (ICollection<Ticket>)updatedDetails;
                user.ApplicationUserDetails = (ICollection<Ticket>?)updatedDetails.TicketsCreated;
                //user.ApplicationUserDetail.TicketsAssigned = updatedDetails.TicketsAssigned;
                user.ApplicationUserDetails = (ICollection<Ticket>?)updatedDetails.TicketHistories;
               // user.ApplicationUserDetails = updatedDetails.DriverStatsId;
                user.ApplicationUserDetails = (ICollection<Ticket>?)updatedDetails.DriverStats;
               // user.ApplicationUserDetails = (ICollection<Ticket>?)updatedDetails.TimelineId;
                user.ApplicationUserDetails = (ICollection<Ticket>?)(updatedDetails.Timelines as ICollection<Timeline>);*/

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteApplicationUserDetailsAsync(string userId)
        {
            var user = await _context.Users.Include(u => u.ApplicationUserDetails)
                                           .FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                _context.Entry(user.ApplicationUserDetails).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }
        /*       public async Task<ApplicationUser> GetUserWithDetailsAsync(string userId)
               {
                   return await _context.Users.Include(u => u.ApplicationUserDetail)
                       .FirstOrDefaultAsync(u => u.Id == userId);
               }

               // Method to update a user's details
               public async Task UpdateApplicationUserDetailsAsync(string userId, ApplicationUserDetail updatedDetails)
               {
                   var user = await GetUserWithDetailsAsync(userId);

                   if (user != null && user.ApplicationUserDetail != null)
                   {
                       user.ApplicationUserDetail.SomeProperty = updatedDetails.SomeProperty;
                       user.ApplicationUserDetail.AnotherProperty = updatedDetails.AnotherProperty;
                       // Continue for all properties to be updated

                       await _context.SaveChangesAsync();
                   }
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

               public async Task<ApplicationUser> GetApplicationUserDetails(string userId)
               {
                   // Assumes ApplicationUser has ApplicationUserDetail navigation property
                   return await _context.Users.Include(u => u.ApplicationUserDetail)
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
                   return await _context.Users.Include(u => u.ApplicationUserDetail).ToListAsync();
               }

               public async Task UpdateUserDetailAsync(ApplicationUserDetail ApplicationUserDetail)
               {
                   // Here you would need to write code to update ApplicationUserDetail in your database
                   // The exact implementation depends on how you've set up your DbContext and database
                   // Following is a rough example

                   var user = await _context.Users.Include(u => u.ApplicationUserDetail)
                       .FirstOrDefaultAsync(u => u.ApplicationUserDetail.Id == ApplicationUserDetail.Id);

                   if (user != null)
                   {
                       user.ApplicationUserDetail = ApplicationUserDetail;
                       await _context.SaveChangesAsync();
                   }
               }
               public async Task UpdateApplicationUserDetailsAsync(string userId)
               {
                   // UserDetail in your database
                   // The exact implementation depends on how you've set up your DbContext and database
                   // Following is a rough example

                   var user = await _context.Users.Include(u => u.ApplicationUserDetail)
                       .FirstOrDefaultAsync(u => u.ApplicationUserDetail.Id == userId);

                   if (user != null)
                   {
                       user.ApplicationUserDetail = user.ApplicationUserDetail;
                       await _context.SaveChangesAsync();
                   }
               }

               public async Task<string> GetCurrentUserIdAsync()
               {
                   return (await _context.Users.FirstOrDefaultAsync()).Id;
               }*/
    }
}
