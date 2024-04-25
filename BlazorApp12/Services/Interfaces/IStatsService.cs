namespace BlazorApp1.Services.Interfaces
{
    public interface IStatsService<T, TStats>
    {
        Task<TStats> GetStatsAsync();
    }
}
