using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BlazorApp1.Repositories
{
    public class SoftwareRepository : ISoftwareRepository
    {
        private readonly ApplicationDbContext _context;

        public SoftwareRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Software> GetSoftwareByIdAsync(int id)
        {
            return await _context.Softwares.FindAsync(id);
        }

        public async Task<List<Software>> GetAllSoftwareAsync()
        {
            return await _context.Softwares.ToListAsync();
        }

        public async Task AddSoftwareAsync(Software software)
        {
            _context.Softwares.Add(software);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSoftwareAsync(Software software)
        {
            _context.Softwares.Update(software);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSoftwareAsync(int id)
        {
            var software = await _context.Softwares.FindAsync(id);
            _context.Softwares.Remove(software);
            await _context.SaveChangesAsync();
        }
    }
}
