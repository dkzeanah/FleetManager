namespace BlazorApp1.CarModels.Utils
{
    public interface IActivity
    {
        string Name { get; }
        decimal InitialValue { get; }
        decimal CurrentValue { get; }
        void UpdateValue(decimal newValue);
    }
}
