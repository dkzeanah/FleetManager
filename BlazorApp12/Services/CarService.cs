using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
      //  private readonly ICarStaticDetailRepository _carStaticDetailRepository;
        private readonly IUserCarEventRepository _eventRepository;
        public CarService(ICarRepository carRepository, IUserCarEventRepository eventRepository) //, ICarStaticDetailRepository carStaticDetailRepository)
        {
            _carRepository = carRepository;
            _eventRepository = eventRepository;
            //_carStaticDetailRepository = carStaticDetailRepository;
        }

        //moved to here from repository. utilizes eventrepository
        public async Task<int> GetCurrentIdByUserId(string userId)
        {
            UserCarEvent currentEvent = await _eventRepository.GetLatestUserCarEventByUserIdAsync(userId);

            if (currentEvent != null)
            {
                return currentEvent.CarId;
            }
            return 0;
        }

        public async Task<Car> GetById_(int carId)
        {
            return await _carRepository.GetById_(carId);
        }
        // including the car details via eager loading CarStaticDetail
        
        public async Task<List<Car>> GetAll()
        {

             return await _carRepository.GetAll_();
        }


        public async Task<List<Car>> GetAll(CancellationToken cancellationToken)
        {
            return await _carRepository.GetAllAsync();
        }



        //Retrieves all cars along with their associated user IDs using a DTO.
        public async Task<List<CarDto>> GetAllDto()
        {
            return await _carRepository.GetAllDto_();
        }

        public async Task Add_(Car car)
        {
            await _carRepository.Add_(car);
        }

        public async Task Update_(Car car)
        {
            await _carRepository.Update_(car);
        }

        public async Task Delete_(int carId)
        {
            await _carRepository.DeleteById_(carId);
        }
        // TODO: clean my app comments
        /*public async Task<List<Car>> GetAll(CancellationToken cancellationToken)
        {
            return await _carRepository.GetAll_(cancellationToken);
        }*/

        public async Task<bool> AssignUserTo(int carId, string userId)
        {
            bool isSuccessful = await _carRepository.AssignUserTo_(carId, userId);
            return isSuccessful;
        }

/*        public async Task<int> GetCurrentIdByUserId(string userId)
        {
            return await _carRepository.GetByUserId_(userId);
        }*/

        public async Task<bool> AssignUserTo(int carId, string userId, DateTime startDate, DateTime endDate)
        {
            bool isSuccessful = await _carRepository.AssignUserTo_(carId, userId, startDate, endDate);
            return isSuccessful;
        }

        // Additional methods:

        public async Task<List<CarDto>> GetAllDtoByUserId(string userId)
        {
            return await _carRepository.GetAllDtoByUserId_(userId);
        }

        public async Task UpdateMileage(int carId, int mileage)
        {
            await _carRepository.UpdateMileage_(carId, mileage);
        }

        public async Task<string> GetLocation(int carId)
        {
            return await _carRepository.GetLocation_(carId);
        }

        public async Task<int> GetTotalCount()
        {
            return await _carRepository.GetTotalCount_();
        }

        public async Task<List<Car>> GetByLocationSortedByUser(string location)
        {
            return await _carRepository.GetByLocationSortedByUser_(location);
        }

        public async Task<List<Car>> GetByTeleGenerationSortByMilesDescending(string teleGeneration)
        {
            return await _carRepository.GetByTeleGenerationSortByMilesDescending_(teleGeneration);
        }

        public async Task<List<Car>> GetCarsByYearRange(int startYear, int endYear)
        {
            return await _carRepository.GetByYearRange_(startYear, endYear);
        }

        public async Task<List<Car>> GetByMake(string make)
        {
            return await _carRepository.GetByMake_(make);
        }

        public async Task<List<Car>> GetByLocationAndMake(string location, string make)
        {
            return await _carRepository.GetByLocationAndMake_(location, make);
        }

        public async Task<List<Car>> GetByUserId(string userId)
        {
            return await _carRepository.GetByUserId_(userId);
        }

        public async Task<List<Car>> GetAllWithStaticDetails()
        {
            return await _carRepository.GetAllWithStaticDetails_();
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

        public async Task DeleteById(int carId)
        {
             await _carRepository.DeleteById_(carId);
        }

        public async Task<Car> GetById(int carId)
        {
            return await _carRepository.GetById_(carId);
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
            UserCarEvent newEvent = new UserCarEvent
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

            // Create Car UserCarEvent
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
                        var newEvent = new UserCarEvent
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