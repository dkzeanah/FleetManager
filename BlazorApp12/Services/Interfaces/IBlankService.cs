using BlazorApp1.CarModels;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Services.Interfaces
{
    public interface IBlankService
    {
        Task<IEnumerable<Blank>> GetAllBlanks();
        Task<Blank> GetBlank(int id);
        Task AddBlank(Blank blank);
        // Add other methods as required
    }

}
