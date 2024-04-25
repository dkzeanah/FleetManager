using BlazorApp1.Interfaces;

namespace BlazorApp1.Services
{
    public class SearchService : ISearchService
    {
        public event Action OnChange;

        private string _searchString = string.Empty;  // initialize as an empty string

        public string SearchString
        {
            get => _searchString;
            set
            {
                _searchString = value;
                NotifyStateChanged();
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}