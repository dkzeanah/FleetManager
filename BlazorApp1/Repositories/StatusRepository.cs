using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace BlazorApp1.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public StatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Status> GetStatusByIdAsync(int id)
        {
            return await _context.Statuses.FindAsync(id);
        }

        public async Task<List<Status>> GetAllStatusAsync()
        {
            return await _context.Statuses.ToListAsync();
        }

        public async Task AddStatusAsync(Status status)
        {
            _context.Statuses.Add(status);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStatusAsync(Status status)
        {
            _context.Statuses.Update(status);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStatusAsync(int id)
        {
            var status = await _context.Statuses.FindAsync(id);
            _context.Statuses.Remove(status);
            await _context.SaveChangesAsync();
        }
    }

}
