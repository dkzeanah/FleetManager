using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IUserEventDetailRepository
    {
        Task AddContactEventDetailAsync(ContactEventDetail userEventDetail);
        Task AddErrorEventDetailAsync(ErrorEventDetail userEventDetail);
        Task AddNoteEventDetailAsync(NoteEventDetail userEventDetail);
        Task AddUserEventDetailAsync(UserEventDetail userEventDetail);
        Task DeleteUserEventDetailAsync(int id);
        Task<IEnumerable<UserEventDetail>> GetAllUserEventDetailsAsync();
        Task<UserEventDetail> GetContactEventDetailByIdAsync(int id);
        Task<UserEventDetail> GetErrorEventDetailByIdAsync(int id);
        Task<UserEventDetail> GetNoteEventDetailByIdAsync(int id);
        Task<UserEventDetail> GetUserEventDetailByIdAsync(int id);
        Task UpdateUserEventDetailAsync(UserEventDetail userEventDetail);
        // New methods for NoteEventDetail
        //Task<NoteEventDetail> GetNoteEventDetailByIdAsync(int id);
        Task<IEnumerable<NoteEventDetail>> GetAllNoteEventDetailsAsync();
        Task UpdateNoteEventDetailAsync(NoteEventDetail noteEventDetail);
        Task DeleteNoteEventDetailAsync(int id);
        // Inside your IUserEventDetailRepository and IUserEventDetailService interfaces, add these methods:
        Task<List<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId);
        Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId);
        Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId);
        Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId);


        // Repeat this pattern for other types (ErrorEventDetail, ContactEventDetail, etc.)
        /* public interface IUserEventDetailRepository
         {
             Task<UserEventDetail> GetUserEventDetailByIdAsync(int id);
             Task<IEnumerable<UserEventDetail>> GetAllUserEventDetailsAsync();
             Task AddUserEventDetailAsync(UserEventDetail userEventDetail);
             Task UpdateUserEventDetailAsync(UserEventDetail userEventDetail);
             Task DeleteUserEventDetailAsync(int id);
         }*/
    }
}
