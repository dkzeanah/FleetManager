// IIssueService.cs
using BlazorApp1.CarModels;
using BlazorApp1.Repositories;
using BlazorApp1.Repositories.Interfaces;



// IssueService.cs
namespace BlazorApp1.Services.Interfaces
{
    public class IssueService : IIssueService
    {
        private readonly IIssueRepository _issueRepository;

        public IssueService(IIssueRepository issueRepository)
        {
            _issueRepository = issueRepository;
        }

        public async Task<Issue> GetIssueByIdAsync(int id)
        {
            return await _issueRepository.GetIssueByIdAsync(id);
        }

        public async Task<List<Issue>> GetAllIssueAsync()
        {
            return await _issueRepository.GetAllIssueAsync();
        }

        public async Task AddIssueAsync(Issue issue)
        {
            await _issueRepository.AddIssueAsync(issue);
        }

        public async Task UpdateIssueAsync(Issue issue)
        {
            await _issueRepository.UpdateIssueAsync(issue);
        }

        public async Task DeleteIssueAsync(int id)
        {
            await _issueRepository.DeleteIssueAsync(id);
        }
    }
}