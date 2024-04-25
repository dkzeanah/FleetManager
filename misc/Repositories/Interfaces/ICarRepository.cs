using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task Add_(Car car);
        Task<bool> AssignUserTo_(int carId, string userId, DateTime startTime, DateTime endTime);
        Task<bool> AssignUserTo_(int carId, string userId);
        Task Update_(Car car);
        Task Delete_(Car car);
        Task DeleteById_(int carId);
        Task Delete_(int carId);
        Task<Car> GetById_(int carId);
        Task<List<Car>> GetAll_();
        Task<List<Car>> GetAll_(CancellationToken cancellationToken);
        Task<List<CarDto>> GetAllDto_();
        //Task<int> GetCurrentIdForUser_(string userId);
        Task<List<CarDto>> GetAllDtoByUserId_(string userId);
        Task<string> GetLocation_(int carId);
        Task<int> GetTotalCount_();
        Task<List<Car>> GetByLocationSortedByUser_(string location);
        Task<List<Car>> GetByMake_(string make);
        Task<List<Car>> GetByYearRange_(int startYear, int endYear);
        Task<List<Car>> GetByTeleGenerationSortByMilesDescending_(string teleGeneration);
        Task<List<Car>> GetByLocationAndMake_(string location, string make);
        Task<List<Car>> GetAllWithStaticDetails_();
        Task<List<Car>> GetByUserId_(string userId);
        Task UpdateMileage_(int carId, int mileage);
        Task<List<Car>> GetAllAsync();

        // Task<bool> GetCarById_(int carId);
        //Task CreateCarEvent_(int carId, string userId, DateTime startTime, DateTime endTime, string role);
        // Task AssignUserToCar_(int carId, string userId, DateTime startDate, DateTime endDate);
        // Task<Car> GetCurrentCarForUser_(string userId);
        //Task CreateCarBooking_(int carId, string id, DateTime startTime, DateTime endTime);
    }
}
