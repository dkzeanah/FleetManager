using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface IIssueRepository
    {
        Task AddIssueAsync(Issue issue);
        Task DeleteIssueAsync(int id);
        Task<List<Issue>> GetAllIssueAsync();
        Task<Issue> GetIssueByIdAsync(int id);
        Task UpdateIssueAsync(Issue issue);
    }
}