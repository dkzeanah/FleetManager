using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ICar2Repository
    {
        Task Add_(Car2 car2);
        Task<bool> AssignUserTo_(int CarId, string userId, DateTime startTime, DateTime endTime);
        Task<bool> AssignUserTo_(int CarId, string userId);
        Task Update_(Car2 car2);
        Task Delete_(Car2 car2);
        Task DeleteById_(int carId);
        Task Delete_(int car2Id);
        Task<Car2> GetById_(int carId);
        Task<List<Car2>> GetAll_();
        Task<List<Car2>> GetAll_(CancellationToken cancellationToken);
        Task<List<Car2Dto>> GetAllDto_();
        //Task<int> GetCurrentIdForUser_(string userId);
        Task<List<Car2Dto>> GetAllDtoByUserId_(string userId);
        Task<string> GetLocation_(int carId);
        Task<int> GetTotalCount_();
        Task<List<Car2>> GetByLocationSortedByUser_(string location);
        Task<List<Car2>> GetByMake_(string make);
        Task<List<Car2>> GetByYearRange_(int startYear, int endYear);
        Task<List<Car2>> GetByTeleGenerationSortByMilesDescending_(string teleGeneration);
        Task<List<Car2>> GetByLocationAndMake_(string location, string make);
        Task<List<Car2>> GetAllWithStaticDetails_();
        Task<List<Car2>> GetByUserId_(string userId);
        Task UpdateMileage_(int car2Id, int mileage);
        Task<List<Car2>> GetAllAsync();

        // Task<bool> GetCar2ById_(int Car22Id);
        //Task CreateCar2Event_(int Car22Id, string userId, DateTime startTime, DateTime endTime, string role);
        // Task AssignUserToCar2_(int Car22Id, string userId, DateTime startDate, DateTime endDate);
        // Task<Car2> GetCurrentCar2ForUser_(string userId);
        //Task CreateCar2Booking_(int Car22Id, string id, DateTime startTime, DateTime endTime);
    }
}
