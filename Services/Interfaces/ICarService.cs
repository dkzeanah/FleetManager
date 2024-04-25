using global::BlazorApp1.CarModels;

namespace BlazorApp1.Services.Interfaces
{
    public interface ICarService
    {
        Task<Car> GetCarByIdAsync(int carId);
        Task<List<Car>> GetAllCarsAsync(CancellationToken cancellationToken);
        Task<List<Car>> GetAllCarsWithDetailsAsync();
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int carId);
        Task UpdateCarDetailAsync(CarDetail CarDetail);
        Task<bool> AssignUserToCarAsync(int carId, string UserId, DateTime startTime, DateTime endTime);
        Task<int> GetCurrentCarIdForUserIdAsync(string userId);
        Task<bool> ScheduleEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime);

    }
}