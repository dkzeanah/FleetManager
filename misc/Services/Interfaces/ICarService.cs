using BlazorApp1.CarModels.DTO;
using global::BlazorApp1.CarModels;

namespace BlazorApp1.Services.Interfaces
{
    public interface ICarService
    {
        /*Task<Car> GetCarByIdAsync(int carId);
        Task<List<Car>> GetAllCarsAsync(CancellationToken cancellationToken);
        Task<List<Car>> GetAllCarsWithDetailsAsync();
        Task AddCarAsync(Car car);
        Task UpdateCarAsync(Car car);
        Task DeleteCarAsync(int carId);
        Task UpdateCarStaticDetailAsync(CarStaticDetail carStaticDetail);
        Task<bool> AssignUserToCarAsync(int carId, string userId, DateTime startTime, DateTime endTime);
        // (changed)       Task<bool> AssignUserToCarAsync(int carId, string UserId, DateTime startTime, DateTime endTime);

        Task<int> GetCurrentCarIdForUserAsync(string userId);
        Task ScheduleEventAsync(int carId, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName);
        Task CreateCarEventAsync(int carId, string userId, DateTime startDate, DateTime endDate, string role);*/
        Task Add(Car car);
        Task<bool> AssignUserTo(int carId, string userId);
        Task<bool> AssignUserTo(int carId, string userId, DateTime startDate, DateTime endDate);
        Task CreateCarEvent(int carId, string userId, DateTime startDate, DateTime endDate, string role);
        Task DeleteById(int carId);
        Task<List<Car>> GetAll();
        Task<List<Car>> GetAll(CancellationToken cancellationToken);
        Task<List<CarDto>> GetAllDto();
        Task<List<CarDto>> GetAllDtoByUserId(string userId);
        Task<Car> GetById(int carId);
        Task<string> GetLocation(int carId);
        Task<List<Car>> GetByLocationAndMake(string location, string make);
        Task<List<Car>> GetByLocationSortedByUser(string location);
        Task<List<Car>> GetByMake(string make);
        Task<List<Car>> GetByTeleGenerationSortByMilesDescending(string teleGeneration);
        Task<List<Car>> GetByUserId(string userId);
        Task<List<Car>> GetByYearRange(int startYear, int endYear);
        Task<List<Car>> GetAllWithStaticDetails();
        Task<int> GetCurrentIdByUserId(string userId);
        Task<int> GetTotalCount();
        Task ScheduleEvent(int carId, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName);
        Task Update(Car car);
        Task Updateileage(int carId, int mileage);
    }
}