using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Repositories
{
    public class Car2Repository : ICar2Repository
    {
        private readonly ApplicationDbContext _context;
        public Car2Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Car2> GetById_(int car2Id)
        {
            return await _context.Car2s.FirstOrDefaultAsync(c => c.Id == car2Id);
        }
        // including the car2 details via eager loading Car2StaticDetail
        // navigation property using the Include method. modified from:/* public async Task<List<Car2>> GetAllCar2sAsync(){return await _context.Car2s.ToListAsync();}*/
        /*public async Task<List<Car2>> GetAllAsync()
        {
            return await _context.Car2s
               // .Include(c => c.Car2StaticDetails)
                .ToListAsync();
        }*/
        public async Task<List<Car2>> GetAllAsync()
        {
            return await _context.Car2s
                .ToListAsync();
                // .Include(c => c.Car2StaticDetails)
        }
        public async Task<List<Car2>> GetAll_()
        {
            return await _context.Car2s
                // .Include(c => c.Car2StaticDetails)
                .ToListAsync();
        }

        //Retrieves all car2s along with their associated user IDs using a DTO.
        public async Task<List<Car2Dto>> GetAllDto_()
        {
            return await _context.Car2s.Select(car2 => new Car2Dto
            {
                CarId = car2.Id,
                Make = car2.Make ?? "Unknown",
                Model = car2.Model ?? "Unknown",
                Year = car2.Year ?? 0,
                TeleGeneration = car2.TeleGeneration ?? "Unknown",
                Miles = car2.Miles ?? 0,
                Location = car2.Location ?? "Unknown",
                SourceId = car2.SourceId ?? 0,
                UserId = car2.UserId ?? "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" // Default GUID
            }).ToListAsync();
        }
        public async Task Add_(Car2 car2)
        {
            _context.Car2s.Add(car2);
            await _context.SaveChangesAsync();
        }
        public async Task Update_(Car2 car2)
        {
            _context.Car2s.Update(car2);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<Car2>> GetAll_(CancellationToken cancellationToken)
        {
            return await _context.Car2s.ToListAsync(cancellationToken);
        }
        public Task CreateBooking_(int car2Id, int userId, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AssignUserTo_(int car2Id, string userId)
        {
            var car2 = await _context.Car2s.FindAsync(car2Id);
            if (car2 == null)
            {
                throw new Exception("Car2 not found");
            }

            car2.UserId = userId;
            Console.WriteLine($"{car2.UserId} Assigned to {car2.Id} - {car2.Make}");

            // SaveChangesAsync returns the number of entities written to the database
            int numberOfEntitiesWritten = await _context.SaveChangesAsync();
            return numberOfEntitiesWritten > 0;
        }

        /*movedtoservice public async Task<int> GetCurrentIdForUser_(string userId)
         {
             var currentEvent = await _context.Events
                 .Where(e => e.UserId == userId &&
                             e.StartTime <= DateTime.Now &&
                             e.EndTime >= DateTime.Now)
                 .FirstOrDefaultAsync();
             if (currentEvent != null)
             {
                 return currentEvent.Car2Id;
             }
             return 0;
             // Consider using a nullable int (int?) to be able to return null when no car2 is booked
         }*/

        public async Task<bool> AssignUserTo_(int Id, string userId, DateTime startDate, DateTime endDate)
        {
            var car2 = await _context.Car2s.FindAsync(Id);
            if (car2 == null)
            {
                throw new Exception("Car2 not found");
            }

            car2.UserId = userId;
            Console.WriteLine($"{car2.UserId} Assigned to {car2.Id} - {car2.Make}");

            // SaveChangesAsync returns the number of entities written to the database
            int numberOfEntitiesWritten = await _context.SaveChangesAsync();
            return numberOfEntitiesWritten > 0;
        }

        public async Task Delete_(Car2 car2)
        {
            _context.Car2s.Remove(car2);
            await _context.SaveChangesAsync();
        }
        public async Task Delete_(int Id)
        {
            var car2 = await _context.Car2s.FirstOrDefaultAsync(c => c.Id == Id);
            if (car2 != null)
            {
                _context.Car2s.Remove(car2);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteById_(int car2Id)
        {
            _context.Car2s.Select(x => car2Id == x.Id);
            await _context.SaveChangesAsync();
        }

        // Retrieves all car2s along with their associated user IDs using a DTO.
        public async Task<List<Car2Dto>> GetAllDtoByUserId_(string userId)
        {
            return await _context.Car2s
                .Where(c => c.UserId == userId)
                .Select(car2 => new Car2Dto
                {
                    CarId = car2.Id,
                    Make = car2.Make ?? "Unknown",
                    Model = car2.Model ?? "Unknown",
                    Year = car2.Year ?? 0,
                    TeleGeneration = car2.TeleGeneration ?? "Unknown",
                    Miles = car2.Miles ?? 0,
                    Location = car2.Location ?? "Unknown",
                    SourceId = car2.SourceId ?? 0,
                    UserId = car2.UserId ?? "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" // Default GUID
                })
                .ToListAsync();
        }

        //updates the mileage of a car2
        public async Task UpdateMileage_(int car2Id, int mileage)
        {
            var car2 = await _context.Car2s.FindAsync(car2Id);
            if (car2 != null)
            {
                car2.Miles = mileage;
                await _context.SaveChangesAsync();
            }
        }
        //location
        public async Task<string> GetLocation_(int car2Id)
        {
            var car2 = await _context.Car2s.FindAsync(car2Id);
            return car2?.Location ?? "Unknown";
        }

        //total of car2s in database
        public async Task<int> GetTotalCount_()
        {
            return await _context.Car2s.CountAsync();
        }
        public async Task<List<Car2>> GetByLocationSortedByUser_(string location)
        {
            return await _context.Car2s
                .Where(c => c.Location == location)
                .OrderBy(c => c.UserId)
                .ToListAsync();
        }
        public async Task<List<Car2>> GetByTeleGenerationSortByMilesDescending_(string teleGeneration)
        {
            return await _context.Car2s
                .Where(c => c.TeleGeneration == teleGeneration)
                .OrderByDescending(c => c.Miles)
                .ToListAsync();
        }
        //Retrieves car2s within a specified year range.
        public async Task<List<Car2>> GetByYearRange_(int startYear, int endYear)
        {
            return await _context.Car2s
                .Where(c => c.Year >= startYear && c.Year <= endYear)
                .ToListAsync();
        }
        //Retrieves car2s by make
        public async Task<List<Car2>> GetByMake_(string make)
        {
            return await _context.Car2s
                .Where(c => c.Make == make)
                .ToListAsync();
        }
        //Retrieves car2s based on a specific location and make
        public async Task<List<Car2>> GetByLocationAndMake_(string location, string make)
        {
            return await _context.Car2s
                .Where(c => c.Location == location && c.Make == make)
                .ToListAsync();
        }
        //Retrieves car2s assigned to a specific user
        public async Task<List<Car2>> GetByUserId_(string userId)
        {
            return await _context.Car2s
                .Where(c => c.UserId == userId)
                .ToListAsync();
        }
        //Retrieves all car2s with their associated car2 static details.
        public async Task<List<CarModels.Car2>> GetAllWithStaticDetails_()
        {
            return await _context.Car2s
                .Include(c => c.CarStaticDetail)
                .ToListAsync();
        }

       


    }
}
/* public async Task<Car2> GetCar2sByUserId(string userId)
      {
           car2List = await _context.Car2s
              .Where(x =>  x.UserId == userId)
              .FirstOrDefaultAsync();

          if (currentCar2 != null)
          {
              return currentCar2;
          }
           return ;
      }*/

//, IEventRepository eventRepository, ICar2StaticDetailRepository car2StaticDetailRepository)
// _eventRepository = eventRepository;
// _car2StaticDetailRepository = car2StaticDetailRepository;


/*public async Task CreateCar2EventAsync(int car2Id, string userId, DateTime startDate, DateTime endDate, string role)
        {
            // Assuming EventTypeId for car2 booking event is 1
            //int eventTypeId;
            //const int BookingEventTypeId = 1;

            // if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
            // {
            //   throw new Exception($"Unknown role: {role}");
            // } - comments
            int eventTypeId = await GetDefaultEventTypeIdForRoleAsync(role);

            // foreach (var eventTypeId in eventTypes)
            //{
            Event newEvent = new Event
            {
                Car2Id = car2Id,
                UserId = userId,
                EventTypeId = eventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };
            //return 

            await _eventRepository.AddEventAsync(newEvent);

            //}
        }*/
//====
/*public async Task UpdateCar2StaticDetailAsync(Car2StaticDetail Car2StaticDetail)
        {
            await _car2StaticDetailRepository.UpdateCar2StaticDetailAsync(Car2StaticDetail);
        }*/
//====
/*public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mapping = await _context.RoleEventMappings.FirstOrDefaultAsync(r => r.Role == role);

            if (mapping == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;
        }*/
//====
/*public async Task<int> GetDefaultEventTypeIdForRoleAsync(string role)
        {
            var mapping = await _context.RoleEventMappings.FirstOrDefaultAsync(r => r.Role == role);

            if (mapping == null)
            {
                throw new Exception($"No default EventTypeId found for role: {role}");
            }

            return mapping.DefaultEventTypeId;
        }*/
/* public async Task<Car2StaticDetail> GetCar2StaticDetailAsync(int car2Id)
{
   return await _car2StaticDetailRepository.GetCar2StaticDetailByIdAsync(car2Id);
}*/
//====
/* public async Task<Car2StaticDetail> GetCar2StaticDetailAsync(int car2Id)
{
   return await _car2StaticDetailRepository.GetCar2StaticDetailByIdAsync(car2Id);
}*/
//====
// bool isCar2Available = await _eventRepository.IsCar2AvailableAsync(car2Id, startTime, endTime, BookingEventTypeId);

// if (!isCar2Available)
// {
//    throw new Exception("The car2 is not available in the selected timeframe.");
// }

// Check if role is valid
/*gippity delete:
 * if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
{
    throw new Exception($"Unknown role: {role}");
}*/


/*gippity del:

switch (role)
{
    case "Driver":
        eventTypeId = 1;
        break;
    case "Technician":
        eventTypeId = 8;
        break;
    case "Organizer":
        eventTypeId = 2;
        break;
    case "Admin":
        eventTypeId = 4;
        break;
    case "Contact":
        eventTypeId = 5;
        break;
    default:
        throw new Exception($"Unknown role: {role}");
}*/

/*Gippity del
 * Event newEvent = new Event
{
    Car2Id = car2Id,
    UserId = userId,
    EventTypeId = eventTypeId,
    StartTime = startDate,
    EndTime = endDate
};*/

//await _context.Add

/*public async Task<Car2> GetCurrentCar2IdForUserAsync(string userId)
        {
            var currentEvent = await _context.Events
                .Where(e => e.UserID == userId &&
                            e.StartTime <= DateTime.Now &&
                            e.EndTime >= DateTime.Now)
                .FirstOrDefaultAsync();
            if (currentEvent != null)
            {
                return await _context.Car2s
                    .Where(c => c.Car2Id == currentEvent.Car2ID)
                    .FirstOrDefaultAsync();
            }
            return null;*/


//private readonly IEventRepository _eventRepository;
// private readonly ICar2StaticDetailRepository _car2StaticDetailRepository;

/* private static readonly Dictionary<string, List<int>> RoleEventTypes = new Dictionary<string, List<int>>
 {
     {"Driver", new List<int> {6}},
     {"Technician", new List<int> {8}},  // Technician role now maps to two event types
     {"Organizer", new List<int> {2, 4}},
     {"Admin", new List<int> {2}}, //change book car2 to Car2Added
     {"Contact", new List<int> {5}}
 };*/

//private readonly  _eventRepository;
