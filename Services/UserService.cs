using Azure.Core.GeoJson;
using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo;
using System.Collections.Generic;
namespace BlazorApp1.Services
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        //private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository repository, UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userRepository = (UserRepository?)repository;
            _userManager = userManager;
            authenticationStateProvider = authenticationStateProvider;
        }

        public UserService()
        {
        }

        public async Task<string> GetUserRoleAsync(ApplicationUser user)
        {
            var roles = await _userManager.GetRolesAsync(user);
            // This gets the first role - adapt as needed if your users can have multiple roles
            return roles.FirstOrDefault();
        }
        public async Task<string> GetUserRoleAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                // Handle the case when user is not found
                Console.WriteLine("damn");
            }

            var roles = await _userManager.GetRolesAsync(user);
            

            // This gets the first role - adapt as needed if your users can have multiple roles
            return roles.FirstOrDefault();
        }

        public async Task<string> FindByEmailAsync(string userEmail)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user != null)
            {
                return user.Id;  // Return user Id as string
            }
            else
            {
                // Handle the case when user is not found, e.g., throw an exception or return null
                throw new Exception("User not found");
            }

        }


        public async Task<string> GetCurrentUserIdAsync()
        {
            return await _userRepository.GetCurrentUserIdAsync();
           // var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
           // return authState.User?.Identity?.Name;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }

        /*public async Task<ApplicationUser> GetUserByIdAsync(int UserId)
        {
            // Convert the int UserId to string because your repository method accepts a string
            return await _userRepository.GetUserByIdAsync(UserId.ToString());
        }*/

        public async Task<List<ApplicationUser>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        /*public async Task<string> GetUserRoleAsync(string userId)
        {
            var user = await _userService.FindByIdAsync(userId);
            if (user != null)
            {
                var roles = await _userService.GetRolesAsync(user);
                if (roles.Count > 0)
                {
                    // Return the first role of the user
                    return roles[0];
                }
            }

            // Return a default value if no role found or user not found
            return "Unknown";
        }*/

        public async Task<List<ApplicationUser>> GetAllUsersWithDetailsAsync()
        {
            // This needs to be implemented in your UserRepository
            throw new NotImplementedException();
        }

        public async Task AddUserAsync(ApplicationUser user)
        {
            await _userRepository.AddUserAsync(user);
        }

        public async Task UpdateUserAsync(ApplicationUser user)
        {
            await _userRepository.UpdateUserAsync(user);
        }


        public async Task UpdateUserDetailAsync(string userId)
        {
            // Here you would need to write code to update ApplicationUserDetail in your database
            // The exact implementation depends on how you've set up your DbContext and database
            // Following is a rough example

            var users = await _userRepository.GetAllUsersAsync();
            foreach (var user in users)
            {
                user.ApplicationUserDetail = await _userRepository.GetUserDetail(user.Id);
            }

            await _userRepository.UpdateUserDetailAsync(userId);
        }

        public async Task UpdateUserDetailAsync(ApplicationUserDetail userDetail)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUserAsync(string userId)
        {
            await _userRepository.DeleteUserAsync(userId);
        }

        public async Task DeleteUserAsync(int UserId)
        {
            // Convert the int UserId to string because your repository method accepts a string
            await _userRepository.DeleteUserAsync(UserId.ToString());
        }
    }
}
