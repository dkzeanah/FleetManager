using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IBlankService
    {
        Task AddBlank(Blank blank);

        Task<IEnumerable<Blank>> GetAllBlanks();
        Task<Blank> GetBlankById(int id);
        Task UpdateBlank(Blank entity);
        Task DeleteBlank(int id);
        // Add other methods as required
       /* Task<IEnumerable<Blank>> GetAllBlanks();
        Task AddBlank(Blank blank);
        Task UpdateBlank(Blank blank);
        Task DeleteBlank(int id);*/
    }

}
