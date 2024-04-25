using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ICarStaticDetailRepository
    {

        //
        //Task<IEnumerable<CarStaticDetails>> GetCarsWithSpecificDetail(string detail);
        public Task<CarStaticDetail> GetCarStaticDetailByIdAsync(int carId);
        public Task<List<CarStaticDetail>> GetAllCarStaticDetailsAsync();
        public Task AddCarStaticDetailAsync(CarStaticDetail car);
        public Task UpdateStaticDetail_(CarStaticDetail car);
        public Task DeleteCarStaticDetailAsync(int carId);
        Task<CarStaticDetail> GetByCarId_(int carId);
        //Task<CarStaticDetail> GetCarStaticDetailAsync(int carId);
    }
}
