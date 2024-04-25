using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IUserEventDetailService
    {
        Task<UserEventDetail> GetUserEventDetailByIdAsync(int id);
        Task<IEnumerable<UserEventDetail>> GetAllUserEventDetailsAsync();
        Task<bool> AddUserEventDetailAsync(UserEventDetail userEventDetail);
        Task<bool> UpdateUserEventDetailAsync(UserEventDetail userEventDetail);
        Task<bool> DeleteUserEventDetailAsync(int id);
        Task<IEnumerable<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId);
        // Inside your IUserEventDetailRepository and IUserEventDetailService interfaces, add these methods:
        Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId);
        Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId);
        Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId);
        //Task<List<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId);
    }
}
