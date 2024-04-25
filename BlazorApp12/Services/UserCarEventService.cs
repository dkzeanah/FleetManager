using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class UserCarEventService : IUserCarEventService
    {
        private readonly ApplicationDbContext _context;

        private readonly IUserCarEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;
        //private readonly IUserCarEventDetailRepository _userCarEventDetailRepository;
        private readonly IRoleEventMappingRepository _roleEventMappingRepository;
        private readonly string userId;

        public UserCarEventService(ApplicationDbContext context, IUserCarEventRepository eventRepository, IEventTypeRepository eventTypeRepository, IRoleEventMappingRepository roleEventMappingRepository)
        {
            _context = context;
            _eventRepository = eventRepository;
            _eventTypeRepository = eventTypeRepository;
           // _userEventDetailRepository = userUserCarEventDetailRepository;
            _roleEventMappingRepository = roleEventMappingRepository;
        }

        public UserCarEventService()
        {
        }
        public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mapping = await _context.RoleEventMappings.FirstOrDefaultAsync(r => r.RoleId == role);

            if (mapping == null)
            {
                throw new Exception($"No default UserCarEventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;
        }
        public async Task<IEnumerable<UserCarEvent>> GetUserCarEventsWithDetailsByUserIdAsync(string userId)
        {
            return (IEnumerable<UserCarEvent>)await _context.UserEvents
                .Include(u => u.UserEventDetails)
                .Where(u => u.UserId == userId)
                .ToListAsync();
        }

        public async Task<UserCarEvent> GetUserCarEventByIdAsync(int id)
        {
            return await _eventRepository.GetEventByIdAsync(id);
        }
        async Task<List<UserCarEvent>> GetUserCarEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }


        public async Task<CarModels.EventType> GetEventTypeByIdAsync(int id)
        {
            return await _eventTypeRepository.GetEventTypeByIdAsync(id);
        }

        public async Task<UserCarEvent> AddUserCarEventAsync(UserCarEvent newUserCarEvent)
        {
            await _eventRepository.AddUserCarEventAsync(newUserCarEvent);
            return newUserCarEvent;
        }

        public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            return await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId);
        }

        public async Task<List<UserCarEvent>> GetAllUserCarEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }

 

        public async Task CreateUserCarEventAsync(int carId, string userEmail, DateTime startDate, DateTime endDate, string role)
        {
            int eventTypeId = await GetDefaultEventTypeIdForRoleAsync(role);


            UserCarEvent newUserCarEvent = new UserCarEvent
            {
                CarId = carId,
                UserId = userId,
                EventTypeId = eventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };
            //return 

            await _eventRepository.AddUserCarEventAsync(newUserCarEvent);
        }
    }
}
