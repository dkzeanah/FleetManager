using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo;
using EventType = BlazorApp1.CarModels.EventType;

namespace BlazorApp1.Services
{
    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;

        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeService _eventTypeService;
        private readonly IUserEventDetailService _userEventDetailService;
        private readonly string userId;

        public EventService(ApplicationDbContext context, IEventRepository eventRepository, IEventTypeService eventTypeService, IUserEventDetailService userEventDetailService)
        {
            _context = context;
            _eventRepository = eventRepository;
            _eventTypeService = eventTypeService;
            _userEventDetailService = userEventDetailService;
        }

        public EventService()
        {
        }
        public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mapping = await _context.RoleEventMappings.FirstOrDefaultAsync(r => r.Role == role);

            if (mapping == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;
        }
        public async Task<IEnumerable<Event>> GetEventsWithDetailsByUserIdAsync(string userId)
        {
            return (IEnumerable<Event>)await _context.UserEvents
                .Include(u => u.UserEventDetails)
                .Where(u => u.UserId == userId)
                .ToListAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _eventRepository.GetEventByIdAsync(id);
        }
        async Task<List<Event>> GetEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }


        public async Task<EventType> GetEventTypeByIdAsync(int id)
        {
            return await _eventTypeService.GetEventTypeByIdAsync(id);
        }

        public async Task<Event> AddEventAsync(Event newEvent)
        {
            await _eventRepository.AddEventAsync(newEvent);
            return newEvent;
        }

        public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            return await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId);
        }

        public async Task<List<Event>> GetAllEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }

        Task<EventType> IEventService.GetEventTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateCarEventAsync(int carId, string userEmail, DateTime startDate, DateTime endDate, string role)
        {
            int eventTypeId = await GetDefaultEventTypeIdForRoleAsync(role);


            Event newEvent = new Event
            {
                CarId = carId,
                UserId = userId,
                EventTypeId = eventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };
            //return 

            await _eventRepository.AddEventAsync(newEvent);
        }
    }
}
