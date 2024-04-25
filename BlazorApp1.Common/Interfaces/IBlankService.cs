using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IBlankService
    {
        Task AddBlank(Blank blank);

        Task<IEnumerable<Blank>> GetAllBlanks();
        Task<Blank> GetBlankById(int id);
        // Add other methods as required
    }

}
