using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.Repositories
{
    public class CarRepository : ICarRepository
    {
        /* private readonly CarsContext _context;

         public CarRepository(CarsContext context)
         {
             _context = context;
         }*/
        private readonly ApplicationDbContext _context;
        private readonly IEventRepository _eventRepository;
        private readonly ICarDetailRepository _CarDetailRepository;

        private static readonly Dictionary<string, List<int>> RoleEventTypes = new Dictionary<string, List<int>>
        {
            {"Driver", new List<int> {6}},
            {"Technician", new List<int> {8}},  // Technician role now maps to two event types
            {"Organizer", new List<int> {2, 4}},
            {"Admin", new List<int> {2}}, //change book car to CarAdded
            {"Contact", new List<int> {5}}
        };

        //private readonly  _eventRepository;


        public CarRepository(ApplicationDbContext context, IEventRepository eventRepository, ICarDetailRepository CarDetailRepository)
        {
            _context = context;
            _eventRepository = eventRepository;
            _CarDetailRepository = CarDetailRepository;

        }

        public CarRepository()
        {
        }

        public async Task<Car> GetCarByIdAsync(int carId)
        {
            return await _context.Cars.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task<List<Car>> GetAllCarsAsync()
        {
            return await _context.Cars.ToListAsync();
        }
        public async Task<List<CarDto>> GetAllCarsAsyncDto()
        {

            return await _context.Cars.Select(car => new CarDto
            {
                CarId = car.CarId,
                Make = car.Make ?? "Unknown",
                Model = car.Model ?? "Unknown",
                Year = car.Year ?? 0,
                TeleGeneration = car.TeleGeneration ?? "Unknown",
                Miles = car.Miles ?? 0,
                Location = car.Location ?? "Unknown",
                SourceId = car.SourceId ?? 0,
                UserId = car.UserId ?? "d02a99db-8c5a-4e0f-9d01-1da28abf91a4" // Default GUID
            }).ToListAsync();

            //return await _context.Cars.ToListAsync();
        }


        public async Task<CarDetail> GetCarDetailAsync(int carId)
        {
            return await _CarDetailRepository.GetCarDetailByIdAsync(carId);
        }

        public async Task AddCarAsync(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarAsync(Car car)
        {
            _context.Cars.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarAsync(int carId)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(c => c.CarId == carId);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateCarDetailAsync(CarDetail CarDetail)
        {
            await _CarDetailRepository.UpdateCarDetailAsync(CarDetail);
        }


        public async Task AssignUserToCarAsync(int carId, string userId, DateTime startDate, DateTime endDate)
        {
            var car = await _context.Cars.FindAsync(carId);
            //var carToAssign = await _context.Cars.FindAsync(car.CarId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            car.UserId = userId;
            Console.WriteLine($"{car.UserId} ADDED");

            await _context.SaveChangesAsync();
        }

        public async Task<List<Car>> GetAllCarsAsync(CancellationToken cancellationToken)
        {
            return await _context.Cars.ToListAsync(cancellationToken);
        }

        public async Task CreateCarBookingAsync(int carId, int userId, DateTime startTime, DateTime endTime)
        {
            throw new NotImplementedException();
        }

        public async Task<Event> CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate) //, string role)
        {
            // Assuming Id for car booking event is 1
           // int eventTypeId = 1;
            const int BookingEventTypeId = 1;

            // bool isCarAvailable = await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, BookingEventTypeId);

            // if (!isCarAvailable)
            // {
            //    throw new Exception("The car is not available in the selected timeframe.");
            // }

            // Check if role is valid
           /* if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
            {
                throw new Exception($"Unknown role: {role}");
            }*/
            

          /*  switch (role)
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
                    Console.WriteLine("\n\n Ok. \n\n");
                    //throw new Exception($"Unknown role: {role}");
            }
*/
            Event newEvent = new Event
            {
                CarId = carId,
                UserId = userId,
                SimpleEventTypeId = BookingEventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };

            //await _context.Add
            await _eventRepository.AddEventAsync(newEvent);
            return newEvent;
        }
        public async Task CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate, string role)
        {
            // Assuming Id for car booking event is 1
            int eventTypeId;
            const int BookingEventTypeId = 1;

            // bool isCarAvailable = await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, BookingEventTypeId);

            // if (!isCarAvailable)
            // {
            //    throw new Exception("The car is not available in the selected timeframe.");
            // }

            // Check if role is valid
            if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
            {
                throw new Exception($"Unknown role: {role}");
            }


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
            }

            Event newEvent = new Event
            {
                CarId = carId,
                UserId = userId,
                Id = eventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };

            //await _context.Add
            await _eventRepository.AddEventAsync(newEvent);
        }
        public async Task AssignUserToCar(int carId, string userId)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            car.UserId = userId;

            await _context.SaveChangesAsync();
        }
        public async Task<bool> AssignUserTo_(int carId, string userId)
        {
            var car = await _context.Cars.FindAsync(carId);
            if (car == null)
            {
                throw new Exception("Car not found");
            }

            car.UserId = userId;
            Console.WriteLine($"{car.UserId} Assigned to {car.CarId} - {car.Make}");

            // SaveChangesAsync returns the number of entities written to the database
            int numberOfEntitiesWritten = await _context.SaveChangesAsync();
            return numberOfEntitiesWritten > 0;
        }
        public async Task<int> GetCurrentCarIdForUserIdAsync(string userId)
        {
            var currentEvent = await _context.Events
                .Where(e => e.UserId == userId &&
                            e.StartTime <= DateTime.Now &&
                            e.EndTime >= DateTime.Now)
                .FirstOrDefaultAsync();
            if (currentEvent != null)
            {
                return (int)currentEvent.CarId;
            }
            return 0; // Consider using a nullable int (int?) to be able to return null when no car is booked
        }
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
    }

    }

