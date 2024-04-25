using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface ISourceRepository
    {
        Task<List<Source>> GetAllSourcesAsync();
        Task<Source> GetSourceByIdAsync(int id);
        Task AddSourceAsync(Source source);
        Task UpdateSourceAsync(Source source);
        Task DeleteSourceAsync(int id);
        Task<List<Source>> GetSourcesAsync();
    }
}