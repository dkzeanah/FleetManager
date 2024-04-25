using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;

namespace BlazorApp1.Services
{
    public class CarStaticDetailService : ICarStaticDetailService
    {
        private readonly ICarStaticDetailRepository _CarStaticDetailRepository;

        public CarStaticDetailService(ICarStaticDetailRepository CarStaticDetailRepository)
        {
            _CarStaticDetailRepository = CarStaticDetailRepository;
        }

        public async Task<CarStaticDetail> GetById(int carId)
        {
            return await _CarStaticDetailRepository.GetByCarId_(carId);
        }

        public async Task<IEnumerable<CarStaticDetail>> GetAll()
        {
            return await _CarStaticDetailRepository.GetAllCarStaticDetailsAsync();
        }

        public async Task Add(CarStaticDetail car)
        {
            await _CarStaticDetailRepository.AddCarStaticDetailAsync(car);
        }

        public async Task Update(CarStaticDetail car)
        {
            await _CarStaticDetailRepository.UpdateStaticDetail_(car);
        }

        public async Task Delete(int carId)
        {
            await _CarStaticDetailRepository.DeleteCarStaticDetailAsync(carId);
        }
    }
}
