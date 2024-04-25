namespace BlazorApp1.CarModels
{
    public interface IDbContext
    {
        IQueryable<Car> Cars { get; }
        IQueryable<Driver> Drivers { get; }
        IQueryable<Event> Events { get; }
    }
}
