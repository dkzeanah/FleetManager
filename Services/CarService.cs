﻿using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.SqlServer.Management.Smo;


namespace BlazorApp1.Services
{


    public class CarService : ICarService
    {

        private readonly ICarRepository _carRepository;
        private readonly ICarDetailRepository _CarDetailRepository;

        private readonly IUserService _userService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> _userManager;
        private readonly IEventRepository _eventRepository;
        private string userId;

        //private readonly ILogger<CarService> _logger;

        #region =========================[ Constructor ]========================================
        public CarService(ICarRepository repository, IEventRepository eventRepository, IUserService userService, ICarDetailRepository CarDetailRepository, Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager)
        {
            _carRepository = repository;
            _eventRepository = eventRepository;
            _userManager = userManager;

            _userService = userService;
            _CarDetailRepository = CarDetailRepository;
        }
        #endregion




        #region =====[ Get ]========================================
        public async Task<int> GetCurrentIdByUserId(string userId)
        {
            Event currentEvent = await _eventRepository.GetLatestEventByUserIdAsync(userId);

            if (currentEvent != null)
            {
                return (int)currentEvent.CarId;
            }
            return 0;
        }
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
                car.CarDetail = await _CarDetailRepository.GetCarDetailByIdAsync(car.CarId);
            }

            return cars;
        }
        #region =====[ Assign User to Car ]========================================
        public async Task<bool> AssignUserToCarAsync(int carId, string userEmail, DateTime startTime, DateTime endTime)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user == null)
            {
                return false;
            }


            // Use user.Id instead of userId
            await _carRepository.CreateCarEventAsync(carId, user.Id, startTime, endTime);

            // Call the new repository method here, also using user.Id
            await _carRepository.AssignUserToCarAsync(carId, user.Id, startTime, endTime);
            return true;
        }


        public async Task<bool> ScheduleEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime)
        {
            // Define the event types using a dictionary
            var eventTypes = new Dictionary<string, int>()
    {
        { "booking", 1 },
        { "otherEventType", 2 },
        // Add more event types as needed
    };

            if (eventTypes.TryGetValue("booking", out int bookingEventTypeId))
            {
                if (await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, bookingEventTypeId))
                {
                    //var user = await _userManager.FindByEmailAsync(userEmail);
                    var newEvent = new Event
                    {
                        CarId = carId,
                        UserId = userId,
                        EventTypeId = bookingEventTypeId,
                        StartTime = startTime,
                        EndTime = endTime
                    };
                    await _eventRepository.AddEventAsync(newEvent);
                }
                else
                {
                    Console.WriteLine("Car is double booked. Users must coordinate.");
                    var user = await _userManager.FindByIdAsync(userId);
                    var newEvent = new Event
                    {
                        CarId = carId,
                        UserId = userId,
                        EventTypeId = bookingEventTypeId,
                        StartTime = startTime,
                        EndTime = endTime
                        
                    };
                    await _eventRepository.AddEventAsync(newEvent);

                    //throw new Exception("The car is not available in the selected timeframe.");
                }
            }
            else
            {
                throw new Exception("Invalid event type.");
            }
            Console.WriteLine($"safe, didnt error, event should be added.");
            return true;
        }

        #endregion
        /*public async Task<bool> AssignUserToCarAsync2(int carId, string userEmail, DateTime startTime, DateTime endTime)             
        {
            var userId = await _userService.FindByEmailAsync(userEmail);
            if (userId == null)
            {
                return false;
            }

            string role = await _userService.GetUserRoleAsync(userId); // Fetch role of the user

            await _carRepository.CreateCarEventAsync(carId, userId, startTime, endTime, role);

            // Call the new repository method here
            await _carRepository.AssignUserToCarAsync(carId, userId, startTime, endTime);
            return true;
        }*/

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
                    if (await _eventRepository.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId))
                    {
                        var newEvent = new Event
                        {
                            CarId = carId,
                            UserId = userId,
                            Id = eventTypeId,
                            StartTime = startTime,
                            EndTime = endTime
                        };
                        await _eventRepository.AddEventAsync(newEvent);
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
        public async Task UpdateCarDetailAsync(CarDetail CarDetail)
        {
            await _CarDetailRepository.UpdateCarDetailAsync(CarDetail);
        }
        #endregion 

        #region =====[ Delete ]=====================================
        public async Task DeleteCarAsync(int carId)
        {
            await _carRepository.DeleteCarAsync(carId);
        }
        #endregion
        public async Task<int> GetCurrentCarIdForUserIdAsync(string userId)
        {
            //var carId = await _carRepository.GetCurrentCarIdForUserAsync(userId);
            return await _carRepository.GetCurrentCarIdForUserIdAsync(userId);
        }


    }
}
