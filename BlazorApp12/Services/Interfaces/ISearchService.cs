namespace BlazorApp1.Services
{
    public interface ISearchService
    {
        string SearchString { get; set; }
        event Action OnChange;
    }
}
