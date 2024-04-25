using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;

namespace BlazorApp1.Services
{
    public class CarDetailService : ICarDetailService
    {
        private readonly ICarDetailRepository _CarDetailRepository;

        public CarDetailService(ICarDetailRepository CarDetailRepository)
        {
            _CarDetailRepository = CarDetailRepository;
        }
        
        public async Task<CarDetail> GetCarDetailByIdAsync(int carId)
        {
            return await _CarDetailRepository.GetCarDetailByIdAsync(carId);
        }

        public async Task<IEnumerable<CarDetail>> GetAllCarDetailsAsync(CancellationToken cancellationToken)
        {
            return await _CarDetailRepository.GetAllCarDetailsAsync(cancellationToken);
        }

        public async Task AddCarDetailAsync(CarDetail car)
        {
            await _CarDetailRepository.AddCarDetailAsync(car);
        }

        public async Task UpdateCarDetailAsync(CarDetail car)
        {
            await _CarDetailRepository.UpdateCarDetailAsync(car);
        }

        public async Task DeleteCarDetailAsync(int carId)
        {
            await _CarDetailRepository.DeleteCarDetailAsync(carId);
        }
    }
}
