using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BlazorApp1.Repositories
{
	/// <summary>
	/// Table Per Hierarchy (TPH) mapping
	/// </summary>

	//This technique is known as eager loading; related data retrieved from database in initial query.
	/*_context.UserEventDetails is accessing the UserEventDetails table in the database.
	 *       .Include(u => u.ApplicationUser) related data from the ApplicationUser
	 *       .Include(u => u.Event) are asking related data from the Event tables loaded with serEventDetails. 
	 *
	 *
	 */
	/* return await _context.UserEventDetails
		 .Include(u => u.ApplicationUser)
		 .Include(u => u.EventId)
		 .ToListAsync();*/
	public class UserEventDetailRepository : IUserEventDetailRepository
	{
		#region =====[ Fields ]========================================home
		private readonly ApplicationDbContext _context;

		public UserEventDetailRepository(ApplicationDbContext context)
		{
			_context = context;
		}
        #endregion
        #region =====[ Constructor ]========================================home

        #endregion
        #region =====[ Gets ]========================================home

        public async Task<UserEventDetail> GetUserEventDetailByIdAsync(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.UserEventDetails
                .Include(u => u.ApplicationUser)
                .Include(u => u.UserEvent)
                    .ThenInclude(ue => ue.Event)
                .FirstOrDefaultAsync(u => u.UserEventDetailId == id);
#pragma warning restore CS8603 // Possible null reference return.
        }



        /*
		 * join the UserEventDetails table with the ApplicationUser table based on the foreign key relationship and include this data in the returned entities.
		 */
        public async Task<IEnumerable<UserEventDetail>> GetAllUserEventDetailsAsync()
		{
			return await _context.UserEventDetails
				.Include(u => u.ApplicationUser)
				.Include(u => u.UserEvent)
					.ThenInclude(ue => ue.Event)
				.ToListAsync();
		}
		public Task<UserEventDetail> GetContactEventDetailByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<UserEventDetail> GetErrorEventDetailByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
		Task<UserEventDetail> IUserEventDetailRepository.GetNoteEventDetailByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<NoteEventDetail>> GetAllNoteEventDetailsAsync()
		{
			return await _context.UserEventDetails.OfType<NoteEventDetail>().ToListAsync();
		}

		public async Task<IEnumerable<ErrorEventDetail>> GetAllErrorEventDetailsAsync()
		{
			return await _context.UserEventDetails.OfType<ErrorEventDetail>().ToListAsync();
		}

		public async Task<IEnumerable<ContactEventDetail>> GetAllContactEventDetailsAsync()
		{
			return await _context.UserEventDetails.OfType<ContactEventDetail>().ToListAsync();
		}
		#endregion
		#region =====[ Add ]========================================home

		public async Task AddUserEventDetailAsync(UserEventDetail userEventDetail)
		{
			_context.UserEventDetails.Add(userEventDetail);
			await _context.SaveChangesAsync();
		}

		public Task AddContactEventDetailAsync(ContactEventDetail userEventDetail)
		{
			throw new NotImplementedException();
		}

		public Task AddErrorEventDetailAsync(ErrorEventDetail userEventDetail)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region =====[ Update ]========================================home
		public async Task UpdateUserEventDetailAsync(UserEventDetail userEventDetail)
		{
			_context.Entry(userEventDetail).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}

		#endregion
		#region =====[ Delete ]========================================home
		public async Task DeleteUserEventDetailAsync(int id)
		{
			var userEventDetail = await _context.UserEventDetails.FindAsync(id);
			if (userEventDetail != null)
			{
				_context.UserEventDetails.Remove(userEventDetail);
				await _context.SaveChangesAsync();
			}
		}
		public async Task DeleteNoteEventDetailAsync(int id)
		{
			var noteEventDetail = await _context.NoteEventDetails.FindAsync(id);
			if (noteEventDetail != null)
			{
				_context.NoteEventDetails.Remove(noteEventDetail);
				await _context.SaveChangesAsync();
			}
		}

		public async Task AddNoteEventDetailAsync(NoteEventDetail noteEventDetail)
		{
			_context.UserEventDetails.Add(noteEventDetail);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateNoteEventDetailAsync(NoteEventDetail noteEventDetail)
		{
			_context.Entry(noteEventDetail).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}


		#endregion
		public async Task<List<UserEventDetail>> GetUserEventDetailsByUserIdAsync(string userId)
		{
			return await _context.UserEventDetails
				.Where(u => u.ApplicationUser.Id == userId)
				.ToListAsync();
		}

		public async Task<List<NoteEventDetail>> GetNoteEventDetailsByUserIdAsync(string userId)
		{
			return await _context.UserEventDetails
				.OfType<NoteEventDetail>()
				.Where(n => n.ApplicationUser.Id == userId)
				.ToListAsync();
		}

		public async Task<List<ErrorEventDetail>> GetErrorEventDetailsByUserIdAsync(string userId)
		{
			return await _context.UserEventDetails
				.OfType<ErrorEventDetail>()
				.Where(e => e.ApplicationUser.Id == userId)
				.ToListAsync();
		}

		public async Task<List<ContactEventDetail>> GetContactEventDetailsByUserIdAsync(string userId)
		{
			return await _context.UserEventDetails
				.OfType<ContactEventDetail>()
				.Where(c => c.ApplicationUser.Id == userId)
				.ToListAsync();
		}


	}
}
