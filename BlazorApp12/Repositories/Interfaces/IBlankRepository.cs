using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories.Interfaces
{
    public interface IBlankRepository
    {
        Task<IEnumerable<Blank>> GetAll();
        Task<Blank> Get(int id);
        Task Add(Blank entity);
        Task Update(Blank entity);
        Task Delete(int id);
    }

}
