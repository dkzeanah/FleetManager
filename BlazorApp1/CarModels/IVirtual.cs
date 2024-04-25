namespace BlazorApp1.CarModels
{
    public interface IVirtual
    {
        string Configuration { get; set; }
        void AddOrUpdateProperty(string key, object value);
        T GetProperty<T>(string key);
    }
}
