using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class Car2Service : ICar2Service
    {
        private readonly ICar2Repository _car2Repository;
        private readonly IEventRepository _eventRepository;
        public Car2Service(ICar2Repository car2Repository, IEventRepository eventRepository)
        {
            _car2Repository = car2Repository;
            _eventRepository = eventRepository;
        }

        //moved to here from repository. utilizes eventrepository
        public async Task<int> GetCurrentIdByUserId(string userId)
        {
            Event currentEvent = await _eventRepository.GetLatestEventByUserIdAsync(userId);

            if (currentEvent != null)
            {
                return currentEvent.CarId;
            }
            return 0;
        }

        public async Task<Car2> GetById_(int carId)
        {
            return await _car2Repository.GetById_(carId);
        }
        // including the car details via eager loading CarStaticDetail
        
        public async Task<List<Car2>> GetAll()
        {
            return await _car2Repository.GetAllAsync();
        }
        public async Task<List<Car2>> GetAll(CancellationToken cancellationToken)
        {
            return await _car2Repository.GetAllAsync();
        }



        //Retrieves all cars along with their associated user IDs using a DTO.
        public async Task<List<Car2Dto>> GetAllDto()
        {
            return await _car2Repository.GetAllDto_();
        }

        public async Task Add_(Car2 car2)
        {
            await _car2Repository.Add_(car2);
        }

        public async Task Update_(Car2 car2)
        {
            await _car2Repository.Update_(car2);
        }

        public async Task Delete_(int carId)
        {
            await _car2Repository.DeleteById_(carId);
        }

        /*public async Task<List<Car>> GetAll(CancellationToken cancellationToken)
        {
            return await _carRepository.GetAll_(cancellationToken);
        }*/

        public async Task<bool> AssignUserTo(int carId, string userId)
        {
            bool isSuccessful = await _car2Repository.AssignUserTo_(carId, userId);
            return isSuccessful;
        }

/*        public async Task<int> GetCurrentIdByUserId(string userId)
        {
            return await _carRepository.GetByUserId_(userId);
        }*/

        public async Task<bool> AssignUserTo(int carId, string userId, DateTime startDate, DateTime endDate)
        {
            bool isSuccessful = await _car2Repository.AssignUserTo_(carId, userId, startDate, endDate);
            return isSuccessful;
        }

        // Additional methods:

        public async Task<List<Car2Dto>> GetAllDtoByUserId(string userId)
        {
            return await _car2Repository.GetAllDtoByUserId_(userId);
        }

        public async Task UpdateMileage(int carId, int mileage)
        {
            await _car2Repository.UpdateMileage_(carId, mileage);
        }

        public async Task<string> GetLocation(int carId)
        {
            return await _car2Repository.GetLocation_(carId);
        }

        public async Task<int> GetTotalCount()
        {
            return await _car2Repository.GetTotalCount_();
        }

        public async Task<List<Car2>> GetByLocationSortedByUser(string location)
        {
            return await _car2Repository.GetByLocationSortedByUser_(location);
        }

        public async Task<List<Car2>> GetByTeleGenerationSortByMilesDescending(string teleGeneration)
        {
            return await _car2Repository.GetByTeleGenerationSortByMilesDescending_(teleGeneration);
        }

        public async Task<List<Car2>> GetCarsByYearRange(int startYear, int endYear)
        {
            return await _car2Repository.GetByYearRange_(startYear, endYear);
        }

        public async Task<List<Car2>> GetByMake(string make)
        {
            return await _car2Repository.GetByMake_(make);
        }

        public async Task<List<Car2>> GetByLocationAndMake(string location, string make)
        {
            return await _car2Repository.GetByLocationAndMake_(location, make);
        }

        public async Task<List<Car2>> GetByUserId(string userId)
        {
            return await _car2Repository.GetByUserId_(userId);
        }

        public async Task<List<Car2>> GetAllWithStaticDetails()
        {
            return await _car2Repository.GetAllWithStaticDetails_();
        }

         

        public Task CreateEvent(int carId, string userId, DateTime startDate, DateTime endDate, string role)
        {
            throw new NotImplementedException();
        }

        public Task ScheduleEvent(int carId, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName)
        {
            throw new NotImplementedException();
        }

        public Task Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Task CreateCarEvent(int carId, string userId, DateTime startDate, DateTime endDate, string role)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car>> GetByYearRange(int startYear, int endYear)
        {
            throw new NotImplementedException();
        }

        /*public Task<int> GetCurrentIdByUserId(string userId)
        {
            throw new NotImplementedException();
        }*/

        public Task Update(Car car)
        {
            throw new NotImplementedException();
        }

        public Task Updateileage(int carId, int mileage)
        {
            throw new NotImplementedException();
        }

        public Task Add(Car2 car2)
        {
            throw new NotImplementedException();
        }

        public Task CreateCar2Event(int car2Id, string userId, DateTime startDate, DateTime endDate, string role)
        {
            throw new NotImplementedException();
        }

        Task<Car2> ICar2Service.GetById(int car2Id)
        {
            throw new NotImplementedException();
        }

        Task<List<Car2>> ICar2Service.GetByYearRange(int startYear, int endYear)
        {
            throw new NotImplementedException();
        }

        public Task Update(Car2 car2)
        {
            throw new NotImplementedException();
        }
    }
}



/*using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;


namespace BlazorApp1.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        //private readonly IEventRepository _eventRepository;
        private readonly IEventService _eventService;
        private readonly ICarStaticDetailRepository _carStaticDetailRepository;
        
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly IUserService _userService;
        //private string userId;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly ILogger<CarService> _logger;

        #region =========================[ Constructor ]========================================
        public CarService(AuthenticationStateProvider authenticationStateProvider,ICarRepository repository, IEventService eventService, IUserService userService, ICarStaticDetailRepository carStaticDetailRepository)
        {
            _authenticationStateProvider = authenticationStateProvider;
            _carRepository = repository;
            _eventService = (EventService?)eventService;
            _userService = userService;
            _carStaticDetailRepository = carStaticDetailRepository;
        }
        #endregion


        public async Task CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate, string role)
        {
            // Assuming EventTypeId for car booking event is 1
            //int eventTypeId;
            //const int BookingEventTypeId = 1;

            // if (!RoleEventTypes.TryGetValue(role, out var eventTypes))
            // {
            //   throw new Exception($"Unknown role: {role}");
            // } - comments
            int eventTypeId = await _eventService.GetDefaultEventTypeIdForRoleAsync(role);

            // foreach (var eventTypeId in eventTypes)
            //{
            Event newEvent = new Event
            {
                CarId = carId,
                UserId = userId,
                EventTypeId = eventTypeId,
                StartTime = startDate,
                EndTime = endDate
            };
            //return 

            await _eventService.AddEventAsync(newEvent);

            //}
        }
        public async Task<CarStaticDetail> GetCarStaticDetailAsync(int carId)
        {
            return await _carStaticDetailRepository.GetCarStaticDetailByIdAsync(carId);
        }
        public async Task UpdateCarStaticDetailAsync(CarStaticDetail CarStaticDetail)
        {
            await _carStaticDetailRepository.UpdateCarStaticDetailAsync(CarStaticDetail);
        }
        #region =====[ Get ]========================================
        public async Task<Car> GetCarByIdAsync(int carId)
        {
            return await _carRepository.GetCarByIdAsync(carId);
        }
        public async Task<List<Car>> GetAllCarsAsync(CancellationToken cancellationToken = default)
        {
            return await _carRepository.GetAllCarsAsync(cancellationToken);
        }
        public async Task<List<Car>> GetAllCarsWithDetailsAsync()
        {
            var cars = await _carRepository.GetAllCarsAsync();

            foreach (var car in cars)
            {
                car.CarStaticDetail = await _carStaticDetailRepository.GetCarStaticDetailByIdAsync(car.CarId);
            }

            return cars;
        }

        public async Task<bool> AssignUserToCarAsync(int carId, string userId, DateTime startTime, DateTime endTime)             
        {
            // Get the current user and roles
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            string role = null;

            if (user.IsInRole("Admin"))
            {
                role = "Admin";
            }
            else if (user.IsInRole("Organizer"))
            {
                role = "Organizer";
            }
            // ... continue for other roles

            if (role == null)
            {
                throw new Exception("No valid roles found for this user.");
            }

            // Continue with your existing logic

            // Assign User to Car
            await _carRepository.AssignUserToCarAsync(carId, userId, startTime, endTime);

            // Create Car Event
            await _eventService.CreateCarEventAsync(carId, userId, startTime, endTime, role);
            //string role = await GetUserRole(userEmail); // Implement this method to get the user's role by their email
            //if (role == null) throw new Exception("User role not found");

            //var userId = await _userService.FindByEmailAsync(userEmail);
            //if (userId == null)
            //{
            //    return false;
            //}

            //string role = await _userService.GetUserRoleAsync(userId); // Fetch role of the user

            //await _carRepository.CreateCarEventAsync(carId, userId, startTime, endTime, role);

            // Call the new repository method here
            //await _carRepository.AssignUserToCarAsync(carId, userId, startTime, endTime);
            return true;
        }

        public async Task ScheduleEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName)
        {
            // Define the event types using a dictionary
            var eventTypes = new Dictionary<string, int>()
    {
        { "booking", 1 },
        { "otherEventType", 2 },
        // Add more event types as needed
    };

            if (eventTypes.TryGetValue(eventTypeName, out int eventTypeId))
            {
                var userId = await _userService.FindByEmailAsync(userEmail);
                if (userId != null)
                {
                    if (await _eventService.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId))
                    {
                        var newEvent = new Event
                        {
                            CarId = carId,
                            UserId = userId,
                            EventTypeId = eventTypeId,
                            StartTime = startTime,
                            EndTime = endTime
                        };
                        await _eventService.AddEventAsync(newEvent);
                    }
                    else
                    {
                        throw new Exception("The car is not available in the selected timeframe.");
                    }
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
            else
            {
                throw new Exception("Invalid event type.");
            }
        }
        #endregion

        #region =====[ Add ]========================================

        public async Task AddCarAsync(Car car)
        {
            await _carRepository.AddCarAsync(car);
        }
        #endregion
       
        #region =====[ Update ]=====================================
        public async Task UpdateCarAsync(Car car)
        {
            await _carRepository.UpdateCarAsync(car);
        }
        *//*public async Task UpdateCarStaticDetailAsync(CarStaticDetail carStaticDetail)
        {
            await _carStaticDetailRepository.UpdateCarStaticDetailAsync(carStaticDetail);
        }*//*
        #endregion 

        #region =====[ Delete ]=====================================
        public async Task DeleteCarAsync(int carId)
        {
            await _carRepository.DeleteCarAsync(carId);
        }
        #endregion
        public async Task<int> GetCurrentCarIdForUserAsync(string userId)
        {
            //var carId = await _carRepository.GetCurrentCarIdForUserAsync(userId);
            return await _carRepository.GetCurrentCarIdForUserAsync(userId);
        }


    }
}
*/