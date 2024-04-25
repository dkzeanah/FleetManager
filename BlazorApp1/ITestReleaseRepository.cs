using BlazorApp1.CarModels;
namespace BlazorApp1.Interfaces
{
    public interface ITestReleaseRepository
    {
        Task<TestRelease> AddAsync(TestRelease testRelease);
        Task<TestRelease> GetByIdAsync(int id);
        Task<List<TestRelease>> GetAllAsync();
        // Add other necessary methods
    }
}
