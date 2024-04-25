namespace BlazorApp1.Services
{
    using global::BlazorApp1.CarModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    namespace BlazorApp1.Services
    {
        public interface ICarStatusService
        {
            Task<CarStatus> GetCarStatusByIdAsync(int carId);
            Task<List<CarStatus>> GetAllCarStatusesAsync();
            Task AddCarStatusAsync(CarStatus carStatus);
            Task UpdateCarStatusAsync(CarStatus carStatus);
            Task DeleteCarStatusAsync(int carId);
        }
    }

}
