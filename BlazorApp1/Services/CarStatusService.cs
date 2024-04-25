using BlazorApp1.Interfaces;
using global::BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    namespace BlazorApp1.Services
    {
        public class CarStatusService : ICarStatusService
        {
            private readonly ICarStatusRepository _carStatusRepository;

            public CarStatusService(ICarStatusRepository carStatusRepository)
            {
                _carStatusRepository = carStatusRepository;
            }

            public async Task<CarStatus> GetCarStatusByIdAsync(int carId)
            {
                return await _carStatusRepository.GetCarStatusByIdAsync(carId);
            }

            public async Task<List<CarStatus>> GetAllCarStatusesAsync()
            {
                return await _carStatusRepository.GetAllCarStatusesAsync();
            }

            public async Task AddCarStatusAsync(CarStatus carStatus)
            {
                _carStatusRepository.AddCarStatusAsync(carStatus);
            }

            public async Task UpdateCarStatusAsync(CarStatus carStatus)
            {
                await _carStatusRepository.UpdateCarStatusAsync(carStatus);
            }

            public async Task DeleteCarStatusAsync(int carId)
            {
                await _carStatusRepository.DeleteCarStatusAsync(carId);
            }
        }
    }

}
