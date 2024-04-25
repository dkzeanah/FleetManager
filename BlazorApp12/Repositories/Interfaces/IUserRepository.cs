using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task AddUserAsync(ApplicationUser user);
        Task DeleteUserAsync(string userId);
        Task DeleteApplicationUserDetailsAsync(string userId);
        Task<List<ApplicationUser>> GetAllUsersAsync();
        Task<ApplicationUser> GetUserByIdAsync(string userId);
        Task<ApplicationUserDetail> GetApplicationUserDetailsAsync(string userId);
        Task UpdateUserAsync(ApplicationUser user);
        Task UpdateApplicationUserDetailsAsync(string userId, ApplicationUserDetail updatedDetails);
        ///*Task<ApplicationUser> GetUserByIdAsync(string userId);
        //Task<List<ApplicationUser>> GetAllUsersAsync();
        //Task<ApplicationUser> GetApplicationUserDetails(string userId);
        //Task AddUserAsync(ApplicationUser user);
        //Task UpdateUserAsync(ApplicationUser user);
        //Task DeleteUserAsync(string userId);
        //Task SaveChangesAsync();
        //Task UpdateApplicationUserDetailsAsync(string userId);
        //Task<string> GetCurrentUserIdAsync();*/
    }
}
