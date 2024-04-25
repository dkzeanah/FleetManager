
using BlazorApp1.CarModels;
using BlazorApp1.CarModels.DTO;

namespace BlazorApp1.Services.Interfaces
{
    public interface ICar2Service
    {
        /*Task<Car2> GetCar2ByIdAsync(int car2Id);
        Task<List<Car2>> GetAllCar2sAsync(CancellationToken cancellationToken);
        Task<List<Car2>> GetAllCar2sWithDetailsAsync();
        Task AddCar2Async(Car2 car2);
        Task UpdateCar2Async(Car2 car2);
        Task DeleteCar2Async(int car2Id);
        Task UpdateCar2StaticDetailAsync(Car2StaticDetail car2StaticDetail);
        Task<bool> AssignUserToCar2Async(int car2Id, string userId, DateTime startTime, DateTime endTime);
        // (changed)       Task<bool> AssignUserToCar2Async(int car2Id, string UserId, DateTime startTime, DateTime endTime);

        Task<int> GetCurrentCar2IdForUserAsync(string userId);
        Task ScheduleEventAsync(int car2Id, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName);
        Task CreateCar2EventAsync(int car2Id, string userId, DateTime startDate, DateTime endDate, string role);*/
        Task Add(Car2 car2);
        Task<bool> AssignUserTo(int car2Id, string userId);
        Task<bool> AssignUserTo(int car2Id, string userId, DateTime startDate, DateTime endDate);
        Task CreateCar2Event(int car2Id, string userId, DateTime startDate, DateTime endDate, string role);
        Task DeleteById(int car2Id);
        Task<List<Car2>> GetAll();
        Task<List<Car2>> GetAll(CancellationToken cancellationToken);
        Task<List<Car2Dto>> GetAllDto();
        Task<List<Car2Dto>> GetAllDtoByUserId(string userId);
        Task<Car2> GetById(int car2Id);
        Task<string> GetLocation(int car2Id);
        Task<List<Car2>> GetByLocationAndMake(string location, string make);
        Task<List<Car2>> GetByLocationSortedByUser(string location);
        Task<List<Car2>> GetByMake(string make);
        Task<List<Car2>> GetByTeleGenerationSortByMilesDescending(string teleGeneration);
        Task<List<Car2>> GetByUserId(string userId);
        Task<List<Car2>> GetByYearRange(int startYear, int endYear);
        Task<List<Car2>> GetAllWithStaticDetails();
        Task<int> GetCurrentIdByUserId(string userId);
        Task<int> GetTotalCount();
        Task ScheduleEvent(int car2Id, string userEmail, DateTime startTime, DateTime endTime, string eventTypeName);
        Task Update(Car2 car2);
        Task Updateileage(int car2Id, int mileage);
    }
}