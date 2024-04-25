namespace BlazorApp1.Interfaces
{
    public interface ISearchService
    {
        string SearchString { get; set; }
        event Action OnChange;
    }
}
