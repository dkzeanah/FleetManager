using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ICarStatusRepository
    {
        Task<CarStatus> GetCarStatusByIdAsync(int carId);
        Task<List<CarStatus>> GetAllCarStatusesAsync();
        Task AddCarStatus(CarStatus carStatus);
        Task UpdateCarStatusAsync(CarStatus carStatus);
        Task DeleteCarStatusAsync(int carId);
        Task<bool> AddCarStatusAsync(CarStatus carStatus);
       
    }

}
