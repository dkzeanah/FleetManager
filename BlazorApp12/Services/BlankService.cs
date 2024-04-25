using BlazorApp1.CarModels;
using BlazorApp1.Repositories.Interfaces;
using BlazorApp1.Services.Interfaces;

namespace BlazorApp1.Services
{
    public class BlankService : IBlankService
    {
        private readonly IBlankRepository _blankRepository;

        public BlankService(IBlankRepository blankRepository)
        {
            _blankRepository = blankRepository;
        }

        public Task<IEnumerable<Blank>> GetAllBlanks()
        {
            return _blankRepository.GetAll();
        }

        public Task<Blank> GetBlank(int id)
        {
            return _blankRepository.Get(id);
        }

        public Task AddBlank(Blank blank)
        {
            return _blankRepository.Add(blank);
        }
        // Implement other methods as required
    }
}
