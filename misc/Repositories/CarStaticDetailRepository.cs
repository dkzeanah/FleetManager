using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using global::BlazorApp1.CarModels;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Repositories
{
    public class CarStaticDetailRepository : ICarStaticDetailRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IEventRepository _eventRepository;

        public CarStaticDetailRepository(ApplicationDbContext context, IEventRepository eventRepository)
        {
            _context = context;
            _eventRepository = eventRepository;
        }

       // public CarStaticDetailRepository()
       // {
       // }

        public async Task<CarStaticDetail> GetCarStaticDetailByIdAsync(int carId)
        {
            return await _context.CarStaticDetails.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task<List<CarStaticDetail>> GetAllCarStaticDetailsAsync()
        {
            return await _context.CarStaticDetails.ToListAsync();
        }
        public async Task<CarStaticDetail> GetByCarId_(int carId)
        {
            return await _context.CarStaticDetails.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task AddCarStaticDetailAsync(CarStaticDetail car)
        {
            _context.CarStaticDetails.Add(car);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStaticDetail_(CarStaticDetail car)
        {
            _context.CarStaticDetails.Update(car);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCarStaticDetailAsync(int carId)
        {
            var car = await _context.CarStaticDetails.FirstOrDefaultAsync(c => c.CarId == carId);
            if (car != null)
            {
                _context.CarStaticDetails.Remove(car);
                await _context.SaveChangesAsync();
            }
        }


        ////////////END
    }
}


