using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using global::BlazorApp1.CarModels;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Repositories
{
    public class CarDetailRepository : ICarDetailRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventRepository _eventRepository;

        public CarDetailRepository(ApplicationDbContext context, IEventRepository eventRepository)
        {
            _context = context;
            _eventRepository = eventRepository;
        }

        public CarDetailRepository()
        {
        }

        public async Task<CarDetail> GetCarDetailByIdAsync(int carId)
        {
            return await _context.CarDetails.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task<List<CarDetail>> GetAllCarDetailsAsync(CancellationToken cancellationToken = default)
        {
            return await _context.CarDetails.ToListAsync(cancellationToken);
        }

        public async Task AddCarDetailAsync(CarDetail car)
        {
            _context.CarDetails.Add(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCarDetailAsync(CarDetail car)
        {
            _context.CarDetails.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarDetailAsync(int carId)
        {
            var car = await _context.CarDetails.FirstOrDefaultAsync(c => c.CarId == carId);
            if (car != null)
            {
                _context.CarDetails.Remove(car);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<CarDetail>> GetAllCarDetailsAsync()
        {
            throw new NotImplementedException();
        }
        ////////////END
    }
}


