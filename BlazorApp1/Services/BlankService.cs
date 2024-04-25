using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

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

        public Task<Blank> GetBlankById(int id)
        {
            return _blankRepository.Get(id);
        }

        public Task AddBlank(Blank blank)
        {
            return _blankRepository.Add(blank);
        }

        public async Task UpdateBlank(Blank entity)
        {
             await _blankRepository.Update(entity);
        }

        public async Task DeleteBlank(int id)
        {
            await _blankRepository.Delete(id);
        }
        // Implement other methods as required
    }
}
