using BlazorApp1.CarModels;

namespace BlazorApp1.Services
{
    public interface ICarStaticDetailService
    {
        Task<CarStaticDetail> GetById(int carId);
        Task<IEnumerable<CarStaticDetail>> GetAll();
        Task Add(CarStaticDetail car);
        Task Update(CarStaticDetail car);
        Task Delete(int carId);
    }
}
