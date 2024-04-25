using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserDetail(string userId);
        Task AddUserAsync(ApplicationUser user);
        Task UpdateUserAsync(ApplicationUser user);
        Task DeleteUserAsync(string userId);
        Task SaveChangesAsync();
        Task UpdateUserDetailAsync(string userId);
        Task<string> GetCurrentUserIdAsync();
    }
}
