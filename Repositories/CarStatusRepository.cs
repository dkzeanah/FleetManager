using BlazorApp1.CarModels;
using BlazorApp1.Data;
using BlazorApp1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Repositories
{
    //CarStatus
    

    public class CarStatusRepository : ICarStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public CarStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CarStatus> GetCarStatusByIdAsync(int carId)
        {
            return await _context.CarStatuses.FindAsync(carId);
        }

        public async Task<List<CarStatus>> GetAllCarStatusesAsync()
        {
            return await _context.CarStatuses.ToListAsync();
        }

        public async Task AddCarStatus(CarStatus carStatus)
        {
            _context.CarStatuses.Add(carStatus);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarStatusAsync(CarStatus carStatus)
        {
            _context.Entry(carStatus).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarStatusAsync(int carId)
        {
            var carStatus = await _context.CarStatuses.FindAsync(carId);
            _context.CarStatuses.Remove(carStatus);
            await _context.SaveChangesAsync();
        }

        public Task<bool> AddCarStatusAsync(CarStatus carStatus)
        {
            throw new NotImplementedException();
        }
    }

    // Issues, ErrorLog, Logger, Software, Status and other tables would follow the same pattern.
    // Just replace CarStatus with the name of the table
}

