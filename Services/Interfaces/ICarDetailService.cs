using BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    public interface ICarDetailService
    {
        Task<CarDetail> GetCarDetailByIdAsync(int carId);
        Task<IEnumerable<CarDetail>> GetAllCarDetailsAsync(CancellationToken cancellationToken);
        Task AddCarDetailAsync(CarDetail car);
        Task UpdateCarDetailAsync(CarDetail car);
        Task DeleteCarDetailAsync(int carId);
    }
}
