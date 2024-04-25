namespace BlazorApp1.Services.Orchestrators
{
    using global::BlazorApp1.Services.Interfaces;
    using System;
    using System.Threading.Tasks;

    namespace BlazorApp1.Services
    {
        public class UserCarService
        {
            private readonly ICarService _carService;
            private readonly IUserCarEventService _eventService;

            public UserCarService(ICarService carService, IUserCarEventService eventService)
            {
                _carService = carService;
                _eventService = eventService;
            }

            public async Task AssignUserToCarAsync(int carId, string userId, DateTime startDate, DateTime endDate)
            {
                await _carService.AssignUserTo(carId, userId, startDate, endDate);
            }

            public async Task CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate, string role)
            {
                await _carService.CreateCarEvent(carId, userId, startDate, endDate, role);
            }

            public async Task ScheduleEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName)
            {
                await _carService.ScheduleEvent(carId, userEmail, startTime, endTime, eventTypeName);
            }

            public async Task<bool> IsCarAvailableAsync(int carId, DateTime startTime, DateTime endTime, int eventTypeId)
            {
                return await _eventService.IsCarAvailableAsync(carId, startTime, endTime, eventTypeId);
            }

            // ... Add more methods as needed
        }
    }

}
