using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using BlazorApp1.Repositories;
using BlazorApp1.Interfaces;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BlazorApp1.Services
{
    public class EventService : IEventService
    {
        //private readonly ApplicationDbContext _context;

        private readonly IEventRepository _eventRepository;
        private readonly IEventTypeRepository _eventTypeRepository;

        private readonly ISimpleEventTypeRepository _simpleEventTypeRepository;
        private readonly IUserEventDetailRepository _userEventDetailRepository;
        private readonly IRoleEventMappingRepository _roleEventMappingRepository;
        private readonly string userId;


        public EventService(IEventRepository eventRepository, ISimpleEventTypeRepository simpleEventTypeRepository, IUserEventDetailRepository userEventDetailRepository, IEventTypeRepository eventTypeRepository, IRoleEventMappingRepository roleEventMappingRepository)
        {
            //_context = context;
            _eventRepository = eventRepository;
            _eventTypeRepository = eventTypeRepository;
            _simpleEventTypeRepository = simpleEventTypeRepository;

            _roleEventMappingRepository = roleEventMappingRepository;

            _userEventDetailRepository = userEventDetailRepository;
        }
        /* public async Task<int> GetDefaultEventTypeIdForRoleAsync(int roleId)
         {
             var mapping = await _eventRepository.GetDefaultEventTypeIdForRoleAsync(role);
             if (mapping == null)
             {
                 throw new Exception($"No default EventTypeId found for role: {role}");
             }

             return mapping.DefaultEventTypeId;

             // _context.RoleEventMappings.FirstOrDefault(ev => EventType.)
         }*/


        public async Task UpdateEventAsync(Event newEvent)
        {
            await _eventRepository.UpdateEventAsync(newEvent);
        }
        //public async Task DeleteEventAsync(int id)
        //{
        //    await _eventRepository.DeleteEventAsync(id);
        //}
        public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mappingId = await _eventRepository.GetDefaultEventTypeIdForRoleAsync(role);
            if (mappingId == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mappingId;

            // _context.RoleEventMappings.FirstOrDefault(ev => EventType.)
        }
        public async Task<IEnumerable<Event>> GetEventsWithDetailsByUserIdAsync(string userId)
        {
            return (IEnumerable<Event>)await _eventRepository.GetAllEventsByUserIdAsync(userId);
                
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
            return await _eventTypeRepository.GetEventTypeByIdAsync(id);
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

/*public async Task<IEnumerable<Event>> GetEventsWithDetailsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }*/

       /* public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _eventRepository.GetEventByIdAsync(id);
        }*/
        /*async Task<List<Event>> GetEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }*/


        public async Task<SimpleEventType> GetSimpleEventTypeByIdAsync(int id)
        {
            return await _simpleEventTypeRepository.GetSimpleEventTypeByIdAsync(id);
        }

       /* public async Task<Event> AddEventAsync(Event newEvent)
        {
            await _eventRepository.AddEventAsync(newEvent);
            return newEvent;
        }*/

       /* public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            return await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId);
        }*/

      /*  public async Task<List<Event>> GetAllEventsByUserIdAsync(string userId)
        {
            return await _eventRepository.GetAllEventsByUserIdAsync(userId);
        }*/

        Task<SimpleEventType> IEventService.GetEventTypeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventType>> GetAllEventTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddEventTypeAsync(EventType eventType)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEventTypeAsync(EventType eventType)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEventTypeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EventType>> GetEventTypesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            throw new NotImplementedException();
        }

        public Task AddRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            throw new NotImplementedException();
        }

    

        public async Task DeleteEventAsync(int id)
        {
            await _eventRepository.DeleteEventAsync(id);
                }
    }
}