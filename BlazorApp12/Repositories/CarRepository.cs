using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;
        //private readonly ICarStaticDetailRepository _carStaticDetailRepository;

        public CarRepository(ApplicationDbContext context) //, ICarStaticDetailRepository carStaticDetailRepository)
        {
            _context = context;
            //_carStaticDetailRepository = carStaticDetailRepository;
        }

        public async Task<Car> GetById_(int carId)
        {
            return await _context.Cars.FirstOrDefaultAsync(c => c.Id == carId);
        }
        // including the car details via eager loading CarStaticDetail
        // navigation property using the Include method. modified from:/* public async Task<List<Car>> GetAllCarsAsync(){return await _context.Cars.ToListAsync();}*/
        /*public async Task<List<Car>> GetAllAsync()
        {
            return await _context.Cars
               // .Include(c => c.CarStaticDetails)
                .ToListAsync();
        }*/
        public async Task<List<Car>> GetAllAsync()
        {
            return await _context.Cars
              //.Include(c => c.CarStaticDetail)
        //.Where(c => CarId == c.Id)
        .ToListAsync();
            /*.Include(c => c.CarStaticDetail)
           .ToListAsync();*/
        }

        public async Task<List<Car>> GetAll_()
        {
            return await _context.Cars
              
        //.ToListAsync();
 //           .Include(c => c.CarStaticDetail)
            .ToListAsync();
        }

        //Retrieves all cars along with their associated user IDs using a DTO.
        public async Task<List<CarDto>> GetAllDto_()
        {
            return await _context.Cars.Select(car => new CarDto
            {
                CarId = car.Id,
                Make = car.Make ?? "Unknown",
                Model = car.Model ?? "Unknown",
                Year = car.Year ?? 0,
                TeleGeneration = car.TeleGeneration ?? "Unknown",
                Miles = car.Miles ?? 0,
                Location = car.Location ?? "Unknown",
                SourceId = car.SourceId ?? 0,
                UserId = car.UserId ?? "Default" // Default GUID
            }).ToListAsync();
        }
        public async Task Add_(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
        }
        public async Task Update_(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }
        
        public async Task<List<Car>> GetAll_(CancellationToken cancellationToken)
        {
            return await _context.Cars.ToListAsync(cancellationToken);
        }
        public Task CreateBooking_(int carId, int userId, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AssignUserTo_(int carId, string userId)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            car.UserId = userId;
            Console.WriteLine($"{car.UserId} Assigned to {car.Id} - {car.Make}");

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
                 return currentEvent.CarId;
             }
             return 0;
             // Consider using a nullable int (int?) to be able to return null when no car is booked
         }*/

        public async Task<bool> AssignUserTo_(int carId, string userId, DateTime startDate, DateTime endDate)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            car.UserId = userId;
            Console.WriteLine($"{car.UserId} Assigned to {car.Id} - {car.Make}");

            // SaveChangesAsync returns the number of entities written to the database
            int numberOfEntitiesWritten = await _context.SaveChangesAsync();
            return numberOfEntitiesWritten > 0;
        }

        public async Task Delete_(Car car)
        {
            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();
        }
        public async Task Delete_(int carId)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.Id == carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteById_(int carId)
        {
            _context.Cars.Select(x => carId == x.Id);
            await _context.SaveChangesAsync();
        }

        // Retrieves all cars along with their associated user IDs using a DTO.
        public async Task<List<CarDto>> GetAllDtoByUserId_(string userId)
        {
            return await _context.Cars
                .Where(c => c.UserId == userId)
                .Select(car => new CarDto
                {
                    CarId = car.Id,
                    Make = car.Make ?? "Unknown",
                    Model = car.Model ?? "Unknown",
                    Year = car.Year ?? 0,
                    TeleGeneration = car.TeleGeneration ?? "Unknown",
                    Miles = car.Miles ?? 0,
                    Location = car.Location ?? "Unknown",
                    SourceId = car.SourceId ?? 0,
                    UserId = car.UserId ?? "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" // Default GUID
                })
                .ToListAsync();
        }

        //updates the mileage of a car
        public async Task UpdateMileage_(int carId, int mileage)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car != null)
            {
                car.Miles = mileage;
                await _context.SaveChangesAsync();
            }
        }
        //location
        public async Task<string> GetLocation_(int carId)
        {
            var car = await _context.Cars.FindAsync(carId);
            return car?.Location ?? "Unknown";
        }

        //total of cars in database
        public async Task<int> GetTotalCount_()
        {
            return await _context.Cars.CountAsync();
        }
        public async Task<List<Car>> GetByLocationSortedByUser_(string location)
        {
            return await _context.Cars
                .Where(c => c.Location == location)
                .OrderBy(c => c.UserId)
                .ToListAsync();
        }
        public async Task<List<Car>> GetByTeleGenerationSortByMilesDescending_(string teleGeneration)
        {
            return await _context.Cars
                .Where(c => c.TeleGeneration == teleGeneration)
                .OrderByDescending(c => c.Miles)
                .ToListAsync();
        }
        //Retrieves cars within a specified year range.
        public async Task<List<Car>> GetByYearRange_(int startYear, int endYear)
        {
            return await _context.Cars
                .Where(c => c.Year >= startYear && c.Year <= endYear)
                .ToListAsync();
        }
        //Retrieves cars by make
        public async Task<List<Car>> GetByMake_(string make)
        {
            return await _context.Cars
                .Where(c => c.Make == make)
                .ToListAsync();
        }
        //Retrieves cars based on a specific location and make
        public async Task<List<Car>> GetByLocationAndMake_(string location, string make)
        {
            return await _context.Cars
                .Where(c => c.Location == location && c.Make == make)
                .ToListAsync();
        }
        //Retrieves cars assigned to a specific user
        public async Task<List<Car>> GetByUserId_(string userId)
        {
            return await _context.Cars
                .Where(c => c.UserId == userId)
                .ToListAsync();
        }
        //Retrieves all cars with their associated car static details.
        public async Task<List<Car>> GetAllWithStaticDetails_()
        {
            return await _context.Cars
                .Include(c => c.CarStaticDetail)
                .ToListAsync();
        }

        
    }
}
/* public async Task<Car> GetCarsByUserId(string userId)
      {
           carList = await _context.Cars
              .Where(x =>  x.UserId == userId)
              .FirstOrDefaultAsync();

          if (currentCar != null)
          {
              return currentCar;
          }
           return ;
      }*/

//, IEventRepository eventRepository, ICarStaticDetailRepository carStaticDetailRepository)
// _eventRepository = eventRepository;
// _carStaticDetailRepository = carStaticDetailRepository;


/*public async Task CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate, string role)
        {
            // Assuming EventTypeId for car booking event is 1
            //int eventTypeId;
            //const int BookingEventTypeId = 1;

            // if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
            // {
            //   throw new Exception($"Unknown role: {role}");
            // } - comments
            int eventTypeId = await GetDefaultEventTypeIdForRoleAsync(role);

            // foreach (var eventTypeId in eventTypes)
            //{
            UserCarEvent newEvent = new UserCarEvent
            {
                CarId = carId,
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
/*public async Task UpdateCarStaticDetailAsync(CarStaticDetail CarStaticDetail)
        {
            await _carStaticDetailRepository.UpdateCarStaticDetailAsync(CarStaticDetail);
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
/* public async Task<CarStaticDetail> GetCarStaticDetailAsync(int carId)
{
   return await _carStaticDetailRepository.GetCarStaticDetailByIdAsync(carId);
}*/
//====
/* public async Task<CarStaticDetail> GetCarStaticDetailAsync(int carId)
{
   return await _carStaticDetailRepository.GetCarStaticDetailByIdAsync(carId);
}*/
//====
// bool isCarAvailable = await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, BookingEventTypeId);

// if (!isCarAvailable)
// {
//    throw new Exception("The car is not available in the selected timeframe.");
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
 * UserCarEvent newEvent = new UserCarEvent
{
    CarId = carId,
    UserId = userId,
    EventTypeId = eventTypeId,
    StartTime = startDate,
    EndTime = endDate
};*/

//await _context.Add

/*public async Task<Car> GetCurrentCarIdForUserAsync(string userId)
        {
            var currentEvent = await _context.Events
                .Where(e => e.UserID == userId &&
                            e.StartTime <= DateTime.Now &&
                            e.EndTime >= DateTime.Now)
                .FirstOrDefaultAsync();
            if (currentEvent != null)
            {
                return await _context.Cars
                    .Where(c => c.CarId == currentEvent.CarID)
                    .FirstOrDefaultAsync();
            }
            return null;*/


//private readonly IEventRepository _eventRepository;
// private readonly ICarStaticDetailRepository _carStaticDetailRepository;

/* private static readonly Dictionary<string, List<int>> RoleEventTypes = new Dictionary<string, List<int>>
 {
     {"Driver", new List<int> {6}},
     {"Technician", new List<int> {8}},  // Technician role now maps to two event types
     {"Organizer", new List<int> {2, 4}},
     {"Admin", new List<int> {2}}, //change book car to CarAdded
     {"Contact", new List<int> {5}}
 };*/

//private readonly  _eventRepository;
