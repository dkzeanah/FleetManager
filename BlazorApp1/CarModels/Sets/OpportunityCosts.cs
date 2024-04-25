namespace BlazorApp1.CarModels.Sets
{
    public class Person
    {
        public string Name { get; set; }
        public double EarningsPerSecond { get; set; }
        public double FreeTimeSeconds { get; set; }

        public double CalculateOpportunityCost(double taskTime)
        {
            return EarningsPerSecond * taskTime;
        }
    }

    public class TaskActivity
    {
        public string? Name { get; set; }
        public double TimeInSeconds { get; set; }
    }

    public class Tool
    {
        public string? Name { get; set; }
        public double Cost { get; set; }
        public double TimeSavedPerUse { get; set; }
    }

    public class OpportunityCostCalculator
    {
        public double CalculateTotalOpportunityCost(Person person, TaskActivity task)
        {
            return person.CalculateOpportunityCost(task.TimeInSeconds);
        }
    }

    public class ToolValueCalculator
    {
        public double CalculateToolValue(Tool tool, double originalTaskTime, int numberOfUses)
        {
            double timeSaved = tool.TimeSavedPerUse * numberOfUses;
            double timeValue = originalTaskTime - timeSaved;
            return tool.Cost / timeValue;
        }
    }
}
