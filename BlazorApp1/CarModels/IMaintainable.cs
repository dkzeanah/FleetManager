namespace BlazorApp1.CarModels
{
    public interface IMaintainable
    {
        void AddProperty(string key, object value);
        void UpdateProperty(string key, object value);
        object GetProperty(string key);
        bool RemoveProperty(string key);
    }
}
