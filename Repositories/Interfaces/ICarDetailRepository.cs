using BlazorApp1.CarModels;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface ICarDetailRepository
    {

        //
        //Task<IEnumerable<CarDetails>> GetCarsWithSpecificDetail(string detail);
        public Task<CarDetail> GetCarDetailByIdAsync(int carId);
        public Task<List<CarDetail>> GetAllCarDetailsAsync(CancellationToken cancellationToken);
        public Task AddCarDetailAsync(CarDetail car);
        public Task UpdateCarDetailAsync(CarDetail car);
        public Task DeleteCarDetailAsync(int carId);
        //Task<CarDetail> GetCarDetailAsync(int carId);
    }
}
