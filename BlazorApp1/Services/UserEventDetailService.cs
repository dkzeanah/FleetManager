using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class UserEventDetailService : IUserEventDetailService
	{
		private readonly IUserEventDetailRepository _userEventDetailRepository;

		public UserEventDetailService(IUserEventDetailRepository userEventDetailRepository)
		{
			_userEventDetailRepository = userEventDetailRepository;
		}

		public async Task<UserEventDetail> GetUserEventDetailByIdAsync(int id)
		{
			return await _userEventDetailRepository.GetUserEventDetailByIdAsync(id);
		}

		public async Task<IEnumerable<UserEventDetail>> GetAllUserEventDetailsAsync()
		{
			return await _userEventDetailRepository.GetAllUserEventDetailsAsync();
		}

		public async Task<bool> AddUserEventDetailAsync(UserEventDetail userEventDetail)
		{
			await _userEventDetailRepository.AddUserEventDetailAsync(userEventDetail);
			return true;
		}

		public async Task<bool> UpdateUserEventDetailAsync(UserEventDetail userEventDetail)
		{
			await _userEventDetailRepository.UpdateUserEventDetailAsync(userEventDetail);
			return true;
		}

		public async Task<bool> DeleteUserEventDetailAsync(int id)
		{
			await _userEventDetailRepository.DeleteUserEventDetailAsync(id);
			return true;
		}

		public async Task<IEnumerable<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId)
		{
			var allUserEventDetails = await _userEventDetailRepository.GetAllUserEventDetailsAsync();

			return allUserEventDetails?.Where(u => u.UserId == userId) ?? Enumerable.Empty<UserEventDetail>();
			/*This modification will handle the case where GetAllUserEventDetailsAsync() returns null by using the null-conditional operator (?.) and the null-coalescing operator (??). If allUserEventDetails is null, it will return an empty collection of UserEventDetail.*/
		}
		public async Task<UserEventDetail> GetUserEventDetailByIdAsync(int id, string detailType)
		{
			switch (detailType.ToLower())
			{
				case "note":
					return await _userEventDetailRepository.GetNoteEventDetailByIdAsync(id);
				case "error":
					return await _userEventDetailRepository.GetErrorEventDetailByIdAsync(id);
				case "contact":
					return await _userEventDetailRepository.GetContactEventDetailByIdAsync(id);
				// add other cases as necessary
				default:
					throw new ArgumentException($"Unknown detail type: {detailType}");
			}
		}
		public async Task AddUserEventDetailAsync(UserEventDetail userEventDetail, string detailType)
		{
			switch (detailType.ToLower())
			{
				case "note":
					await _userEventDetailRepository.AddNoteEventDetailAsync((NoteEventDetail)userEventDetail);
					break;
				case "error":
					await _userEventDetailRepository.AddErrorEventDetailAsync((ErrorEventDetail)userEventDetail);
					break;
				case "contact":
					await _userEventDetailRepository.AddContactEventDetailAsync((ContactEventDetail)userEventDetail);
					break;
				// add other cases as necessary
				default:
					throw new ArgumentException($"Unknown detail type: {detailType}");
			}
		}


		public Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId)
		{
			return _userEventDetailRepository.GetNoteEventDetailsByUserIdAsync(userId);
		}

		public Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId)
		{
			return _userEventDetailRepository.GetErrorEventDetailsByUserIdAsync(userId);
		}

		public Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId)
		{
			return _userEventDetailRepository.GetContactEventDetailsByUserIdAsync(userId);
		}
	}
}
