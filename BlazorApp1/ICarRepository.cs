using BlazorApp1.CarModels;
using Microsoft.AspNetCore.Identity;

namespace BlazorApp1.Interfaces
{
    public interface ICarRepository
    {
        Task<Car> GetCarByIdAsync(int carId);
        Task<List<Car>> GetAllCarsAsync();
        Task<CarDetail> GetCarDetailAsync(int carId);
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int carId);
        Task UpdateCarDetailAsync(CarDetail CarDetail);
        Task<Event> CreateCarEventAsync(int carId, string userId, DateTime startTime, DateTime endTime); //, string role);
        // Task AssignUserToCarAsync(int carId, string userId, DateTime startDate, DateTime endDate);
        Task<int> GetCurrentCarIdForUserIdAsync(string userId);
        Task AssignUserToCarAsync(int carId, string userId, DateTime startTime, DateTime endTime);
        // Task<Car> GetCurrentCarForUserAsync(string userId);
        Task<List<Car>> GetAllCarsAsync(CancellationToken cancellationToken);



        //Task CreateCarBookingAsync(int carId, string id, DateTime startTime, DateTime endTime);
    }
}
