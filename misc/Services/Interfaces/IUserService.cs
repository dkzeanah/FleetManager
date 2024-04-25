﻿using System.Security.Claims;
using BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetUserByIdAsync(string UserId);
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<List<ApplicationUser>> GetAllUsersWithDetailsAsync();
        Task AddUserAsync(ApplicationUser User);
        Task UpdateUserAsync(ApplicationUser User);
        Task DeleteUserAsync(string UserId);
        Task UpdateUserDetailAsync(string userId);
        Task UpdateUserDetailAsync(UserStaticDetail userStaticDetail);
        Task<string> GetUserRoleAsync(string userId);
        Task<string> GetCurrentUserIdAsync();
        Task<string> FindByEmailAsync(string userEmail);
    }
}