using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class UserCarEventRepository : IUserCarEventRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventTypeRepository _eventTypeRepository;

        public UserCarEventRepository(ApplicationDbContext context, IEventTypeRepository eventTypeRepository)
        {
            _context = context;
            _eventTypeRepository = eventTypeRepository;
        }

        public async Task<UserCarEvent> GetEventByIdAsync(int eventId)
        {
            return await _context.UserCarEvents
                .FirstOrDefaultAsync(e => e.Id == eventId);
        }
        public async Task<List<UserCarEvent>> GetAllEventsByEventTypeAsync(int eventTypeId)
        {
            return await _context.UserCarEvents
       .Include(e => e.EventTypeId)
       .Where(e => e.EventTypeId == eventTypeId)
       .ToListAsync();
        }

        public async Task<List<UserCarEvent>> GetAllEventsByUserIdAsync(string userId)
        {
            return await _context.UserCarEvents
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }
        public async Task<UserCarEvent> GetLatestUserCarEventByUserIdAsync(string userId)
        {
            return await _context.UserCarEvents
                .Where(e => e.UserId == userId)
                .OrderByDescending(e => e.Date)
                .FirstOrDefaultAsync();
        }




        public async Task<EventType> GetEventTypeAsync(int eventId)
        {
            return await _context.EventTypes
                .FirstOrDefaultAsync(et => et.Id == eventId);
        }


        public async Task<UserCarEvent> AddUserCarEventAsync(UserCarEvent? newEvent)
        {
            if (newEvent is not null)
                {
            _context.UserCarEvents.Add(newEvent);
            await _context.SaveChangesAsync();
                }
            else
            {
                Console.WriteLine("your here... broke");
            }
            return newEvent;  // Return the newly created UserCarEvent

        }





        public bool IsCarAvailable(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            // Perform the necessary logic to check if the car is available in the selected timeframe for the specified event type
            // Return true if available, false otherwise
            return true;
        }

        public Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int bookingEventTypeId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserCarEventRepository.IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            throw new NotImplementedException();
        }

        /*public async Task UpdateEventTypeAsync(EventType eventType)
        {
            _context.EventTypes.Update(eventType);
            await _context.SaveChangesAsync();
        }*/

        Task<bool> IUserCarEventRepository.IsCarAvailable(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
        {
            throw new NotImplementedException();
        }

        
        CarModels.UserTask IUserCarEventRepository.UpdateEventTypeAsync(EventType eventType)
        {
            throw new NotImplementedException();
        }

        public CarModels.UserTask UpdateEventTypeAsync(EventType eventType)
        {
            throw new NotImplementedException();
        }



        // Implement other methods as needed
    }

}
