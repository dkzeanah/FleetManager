namespace BlazorApp1.Interfaces
{
    public interface IStatsService<T, TStats>
    {
        Task<TStats> GetStatsAsync();
    }
}
