using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace BlazorApp1.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ISimpleEventTypeRepository _simpleEventTypeRepository;

        public EventRepository(ApplicationDbContext context, ISimpleEventTypeRepository simpleEventTypeRepository)
        {
            _context = context;
            _simpleEventTypeRepository = simpleEventTypeRepository;
        }
        public async Task<Event> GetLatestEventByUserIdAsync(string userId)
        {
            return await _context.Events
                .Where(e => e.UserId == userId)
                .OrderByDescending(e => e.Date)
                .FirstOrDefaultAsync();
        }
        public async Task<Event> GetEventByIdAsync(int eventId)
        {
            return await _context.Events
                .FirstOrDefaultAsync(e => e.Id == eventId);
        }
        public async Task<List<Event>> GetAllEventsByEventTypeAsync(int simpleEventTypeId)
        {
            return await _context.Events
       .Include(e => e.SimpleEventType)
       .Where(e => e.SimpleEventTypeId == simpleEventTypeId)
       .ToListAsync();
        }

        public async Task<List<Event>> GetAllEventsByUserIdAsync(string userId)
        {
            return await _context.Events

                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            return await _context.RoleEventMappings.ToListAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            _context.RoleEventMappings.Update(roleEventMapping);
            await _context.SaveChangesAsync();
        }

        public async Task<EventType> GetEventTypeAsync(int eventId)
        {
            return await _context.EventTypes
                .FirstOrDefaultAsync(et => et.Id == eventId);
        }


        public async Task<Event> AddEventAsync(Event newEvent)
        {
            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();
            return newEvent;  // Return the newly created Event

        }

        public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mapping = await _context.RoleEventMappings.FirstOrDefaultAsync(r => r.RoleId == role);
            if (mapping == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;

            // _context.RoleEventMappings.FirstOrDefault(ev => EventType.)
        }





        public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int simpleEventTypeId)
            {
                // Check if the parameters are logically correct
                // startTime should be less than endTime
                if (startTime >= endTime)
                {
                    return false;
                }

                // Fetch all events for the specified car
                var existingEvents = await _context.Events
                    .Where(e => e.CarId == carId)
                    .ToListAsync();

                // Loop through each event to check if there is an overlap
                foreach (var existingEvent in existingEvents)
                {
                    // Check if the existing event overlaps with the new event time frame
                    // We can ignore events that have different types, if needed
                    if (existingEvent.SimpleEventTypeId == simpleEventTypeId &&
                        ((existingEvent.StartTime >= startTime && existingEvent.StartTime < endTime) ||
                         (existingEvent.EndTime > startTime && existingEvent.EndTime <= endTime) ||
                         (existingEvent.StartTime <= startTime && existingEvent.EndTime >= endTime)))
                    {
                        // If there is an overlap, the car is not available
                        return false;
                    }
                }

                // If we get through the loop without finding an overlap, the car is available
                return true;
            }
        public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime)
        {
            // Check if the parameters are logically correct
            // startTime should be less than endTime
            if (startTime >= endTime)
            {
                return false;
            }

            // Fetch all events for the specified car
            var existingEvents = await _context.Events
                .Where(e => e.CarId == carId)
                .ToListAsync();

            // Loop through each event to check if there is an overlap
            foreach (var existingEvent in existingEvents)
            {
                // Check if the existing event overlaps with the new event time frame
                // We can ignore events that have different types, if needed
                if 
                    ((existingEvent.StartTime >= startTime && existingEvent.StartTime < endTime) ||
                     (existingEvent.EndTime > startTime && existingEvent.EndTime <= endTime) ||
                     (existingEvent.StartTime <= startTime && existingEvent.EndTime >= endTime))
                {
                    // If there is an overlap, the car is not available
                    return false;
                }
            }

            // If we get through the loop without finding an overlap, the car is available
            return true;
        }



       public async Task UpdateSimpleEventTypeAsync(SimpleEventType simpleEventType)
        {
            _context.SimpleEventTypes.Update(simpleEventType);
            await _context.SaveChangesAsync();
        }

        public Task UpdateEventTypeAsync(EventType eventType)
        {
            throw new NotImplementedException();
        }

    }

}
