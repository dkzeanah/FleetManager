using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

public class PaymentRepository
{
    private readonly IDbContextFactory<ContactContext> _contextFactory;

    public PaymentRepository(IDbContextFactory<ContactContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<IEnumerable<Payment>> GetAllAsync()
    {
        using (var context = _contextFactory.CreateDbContext())
        {
            return await context.Set<Payment>().ToListAsync();
        }
    }

    public async Task<Payment> GetByIdAsync(int id)
    {
        using (var context = _contextFactory.CreateDbContext())
        {
            return await context.Set<Payment>().FindAsync(id);
        }
    }

    public async Task AddAsync(Payment payment)
    {
        using (var context = _contextFactory.CreateDbContext())
        {
            await context.Set<Payment>().AddAsync(payment);
            await context.SaveChangesAsync();
        }
    }

    // Additional CRUD operations can be added here
}
