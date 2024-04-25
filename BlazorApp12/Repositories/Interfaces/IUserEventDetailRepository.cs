using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IUserEventDetailRepository
    {
        //Task AddContactEventDetailAsync(ContactEventDetail userEventDetail);
        Task AddErrorEventDetailAsync(ErrorEventDetail userEventDetail);
        Task AddNoteEventDetailAsync(NoteEventDetail userEventDetail);
        Task AddUserEventDetailAsync(UserEventDetailGranular userEventDetail);
        Task DeleteUserEventDetailAsync(int id);
        Task<IEnumerable<UserEventDetailGranular>> GetAllUserEventDetailsAsync();
       // Task<UserEventDetailGranular> GetContactEventDetailByIdAsync(int id);
        Task<UserEventDetailGranular> GetErrorEventDetailByIdAsync(int id);
        Task<UserEventDetailGranular> GetNoteEventDetailByIdAsync(int id);
        Task<UserEventDetailGranular> GetUserEventDetailByIdAsync(int id);
        Task UpdateUserEventDetailAsync(UserEventDetailGranular userEventDetail);
        // New methods for NoteEventDetail
        //Task<NoteEventDetail> GetNoteEventDetailByIdAsync(int id);
        Task<IEnumerable<NoteEventDetail>> GetAllNoteEventDetailsAsync();
        Task UpdateNoteEventDetailAsync(NoteEventDetail noteEventDetail);
        Task DeleteNoteEventDetailAsync(int id);
                                                                                                    // Inside your IUserEventDetailRepository and IUserEventDetailService interfaces, add these methods:
        Task<List<UserEventDetailGranular>> GetUserEventDetailsByUserIdAsync(string userId);
        Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId);
        Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId);
        //Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId);


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
