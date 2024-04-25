namespace BlazorApp1.CarModels.Utils
{
    public class Activity : IActivity
    {
        public string Name { get; private set; }
        public decimal InitialValue { get; private set; }
        public decimal CurrentValue { get; private set; }

        public Activity(string name, decimal initialValue)
        {
            Name = name;
            InitialValue = initialValue;
            CurrentValue = initialValue;
        }

        public void UpdateValue(decimal newValue)
        {
            CurrentValue = (CurrentValue + newValue) / 2; // Rolling average calculation
        }
    }
}
