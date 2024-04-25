using BlazorApp1.CarModels;

namespace BlazorApp1.Services.Interfaces
{
    public interface IIssueService
    {
        Task<Issue> GetIssueByIdAsync(int id);
        Task<List<Issue>> GetAllIssueAsync();
        Task AddIssueAsync(Issue issue);
        Task UpdateIssueAsync(Issue issue);
        Task DeleteIssueAsync(int id);
    }
}
