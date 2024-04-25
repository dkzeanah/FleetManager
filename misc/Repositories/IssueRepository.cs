using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class IssueRepository : IIssueRepository
    {
        private readonly ApplicationDbContext _context;

        public IssueRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Issue> GetIssueByIdAsync(int id)
        {
            return await _context.Issues.FindAsync(id);
        }

        public async Task<List<Issue>> GetAllIssueAsync()
        {
            return await _context.Issues.ToListAsync();
        }

        public async Task AddIssueAsync(Issue issue)
        {
            _context.Issues.Add(issue);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateIssueAsync(Issue issue)
        {
            _context.Issues.Update(issue);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIssueAsync(int id)
        {
            var issue = await _context.Issues.FindAsync(id);
            _context.Issues.Remove(issue);
            await _context.SaveChangesAsync();
        }
    }
}
