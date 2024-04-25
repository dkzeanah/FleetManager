using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Vml.Office;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;

namespace BlazorApp1.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        //private readonly ApplicationDbContext context;
        private readonly ISimpleEventTypeRepository _simpleEventTypeRepository;

        public EventRepository(/*ApplicationDbContext context, */ IDbContextFactory<ApplicationDbContext> contextFactory, ISimpleEventTypeRepository simpleEventTypeRepository)
        {
            _contextFactory = contextFactory;

            //context = context;
            _simpleEventTypeRepository = simpleEventTypeRepository;
        }

        public async Task<Event> GetLatestEventByUserIdAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Events
                .Where(e => e.UserId == userId)
                .OrderByDescending(e => e.Date)
                .FirstOrDefaultAsync();
        }
        public async Task<Event> GetEventByIdAsync(int eventId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Events
                .FirstOrDefaultAsync(e => e.Id == eventId);
        }
        public async Task<List<Event>> GetAllEventsByEventTypeAsync(int simpleEventTypeId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Events
       .Include(e => e.SimpleEventType)
       .Where(e => e.SimpleEventTypeId == simpleEventTypeId)
       .ToListAsync();
        }

        public async Task<List<Event>> GetAllEventsByUserIdAsync(string userId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.Events

                .Where(e => e.UserId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<RoleEventMapping>> GetRoleEventMappingsAsync()
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.RoleEventMappings.ToListAsync();
        }

        public async Task UpdateRoleEventMappingAsync(RoleEventMapping roleEventMapping)
        {
            using var context = _contextFactory.CreateDbContext();

            context.RoleEventMappings.Update(roleEventMapping);
            await context.SaveChangesAsync();
        }

        public async Task<EventType> GetEventTypeAsync(int eventId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.EventTypes
                .FirstOrDefaultAsync(et => et.Id == eventId);
        }


        public async Task<Event> AddEventAsync(Event newEvent)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Events.Add(newEvent);
            await context.SaveChangesAsync();
            return newEvent;  // Return the newly created Event

        }

        public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            using var context = _contextFactory.CreateDbContext();

            var mapping = await context.RoleEventMappings.FirstOrDefaultAsync(r => r.RoleId == role);
            if (mapping == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;

            // context.RoleEventMappings.FirstOrDefault(ev => EventType.)
        }





        public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int simpleEventTypeId)
        {
            using var context = _contextFactory.CreateDbContext();

            // Check if the parameters are logically correct
            // startTime should be less than endTime
            if (startTime >= endTime)
            {
                return false;
            }

            // Fetch all events for the specified car
            var existingEvents = await context.Events
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
            using var context = _contextFactory.CreateDbContext();

            // Check if the parameters are logically correct
            // startTime should be less than endTime
            if (startTime >= endTime)
            {
                return false;
            }

            // Fetch all events for the specified car
            var existingEvents = await context.Events
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
            using var context = _contextFactory.CreateDbContext();

            context.SimpleEventTypes.Update(simpleEventType);
            await context.SaveChangesAsync();
        }


        public Task UpdateEventTypeAsync(EventType eventType)
        {
            using var context = _contextFactory.CreateDbContext();

            throw new NotImplementedException();
        }
        public async Task UpdateEventAsync(Event newEvent)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Update(newEvent);
            await context.SaveChangesAsync();
        }
        public async Task DeleteEventAsync(Event newEvent)
        {
            using var context = _contextFactory.CreateDbContext();

            context.Remove(newEvent);
            await context.SaveChangesAsync();
        }
        public async Task DeleteEventAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();

            DeleteEventAsync(id);
            await context.SaveChangesAsync();
        }



    }
}
