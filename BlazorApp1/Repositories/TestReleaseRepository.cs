using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace BlazorApp1.Repositories
{
    public class TestReleaseRepository : ITestReleaseRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;

        public TestReleaseRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<TestRelease> AddAsync(TestRelease testRelease)
        {
            using var context = _dbContextFactory.CreateDbContext();
            context.TestReleases.Add(testRelease);
            await context.SaveChangesAsync();
            return testRelease;
        }

        public async Task<TestRelease> GetByIdAsync(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return await context.TestReleases.FindAsync(id);
        }

        public async Task<List<TestRelease>> GetAllAsync()
        {
            using var context = _dbContextFactory.CreateDbContext();
            return await context.TestReleases.ToListAsync();
        }

        // Implement other methods as needed
    }
}
