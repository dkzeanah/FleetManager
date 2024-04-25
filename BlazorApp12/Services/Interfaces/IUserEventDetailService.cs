using BlazorApp1.CarModels;

namespace BlazorApp1.Services.Interfaces
{
    public interface IUserEventDetailService
    {
        Task<UserEventDetailGranular> GetUserEventDetailByIdAsync(int id);
        Task<IEnumerable<UserEventDetailGranular>> GetAllUserEventDetailsAsync();
        Task<bool> AddUserEventDetailAsync(UserEventDetailGranular userEventDetail);
        Task <bool>UpdateUserEventDetailAsync(UserEventDetailGranular userEventDetail);
        Task <bool>DeleteUserEventDetailAsync(int id);
        Task<IEnumerable<UserEventDetailGranular>> GetUserEventDetailsByUserIdAsync(string userId);
        // Inside your IUserEventDetailRepository and IUserEventDetailService interfaces, add these methods:
        Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId);
        Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId);
        //Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId);
		//Task<List<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId);
	}
}
