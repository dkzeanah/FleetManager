using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using global::BlazorApp1.CarModels;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Repositories
{
    public class CarDetailRepository : ICarDetailRepository
    {
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

        //private readonly ApplicationDbContext context;
        private readonly IEventRepository _eventRepository;

        public CarDetailRepository(/*ApplicationDbContext context, */ IDbContextFactory<ApplicationDbContext> contextFactory, IEventRepository eventRepository)
        {
            _contextFactory = contextFactory;

            // context = context;
            _eventRepository = eventRepository;
        }

        public CarDetailRepository()
        {
        }

        public async Task<CarDetail> GetCarDetailByIdAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.CarDetails.FirstOrDefaultAsync(c => c.CarId == carId);
        }

        public async Task<List<CarDetail>> GetAllCarDetailsAsync(CancellationToken cancellationToken = default)
        {
            using var context = _contextFactory.CreateDbContext();

            return await context.CarDetails.ToListAsync(cancellationToken);
        }

        public async Task AddCarDetailAsync(CarDetail car)
        {
            using var context = _contextFactory.CreateDbContext();

            context.CarDetails.Add(car);
            await context.SaveChangesAsync();
        }

        public async Task UpdateCarDetailAsync(CarDetail car)
        {
            using var context = _contextFactory.CreateDbContext();

            context.CarDetails.Update(car);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCarDetailAsync(int carId)
        {
            using var context = _contextFactory.CreateDbContext();

            var car = await context.CarDetails.FirstOrDefaultAsync(c => c.CarId == carId);
            if (car != null)
            {
                context.CarDetails.Remove(car);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<CarDetail>> GetAllCarDetailsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.CarDetails.ToListAsync();

        }
        ////////////END
    }
}


