namespace BlazorApp1.CarModels
{
    using System;

    public class TimeValueCalculator
    {
        private double salary;
        private double freeTimeSeconds;
        public double worthPerSecond;

        public TimeValueCalculator(double salary, double freeTimeHours)
        {
            this.salary = salary;
            this.freeTimeSeconds = freeTimeHours * 3600; // converting hours to seconds
            CalculateWorthPerSecond();
        }

        private void CalculateWorthPerSecond()
        {
            // Annual salary to seconds per year conversion (assuming 1 year = 365 days)
            double secondsPerYear = 365 * 24 * 3600;
            this.worthPerSecond = salary / secondsPerYear;
        }

        public double CalculateOpportunityCost(double taskDurationSeconds)
        {
            return this.worthPerSecond * taskDurationSeconds;
        }

        public double CalculateTheoreticalGain(double taskValue, double taskDurationSeconds)
        {
            double opportunityCost = CalculateOpportunityCost(taskDurationSeconds);
            return (taskValue - opportunityCost) * (this.freeTimeSeconds / taskDurationSeconds);
        }

        public static string CompareOpportunityCost(TimeValueCalculator person1, TimeValueCalculator person2, double taskDurationSeconds)
        {
            double cost1 = person1.CalculateOpportunityCost(taskDurationSeconds);
            double cost2 = person2.CalculateOpportunityCost(taskDurationSeconds);

            return $"Person 1 Opportunity Cost: {cost1}\nPerson 2 Opportunity Cost: {cost2}";
        }

        public static string CompareTheoreticalGain(TimeValueCalculator person1, TimeValueCalculator person2, double taskValue, double taskDurationSeconds)
        {
            double gain1 = person1.CalculateTheoreticalGain(taskValue, taskDurationSeconds);
            double gain2 = person2.CalculateTheoreticalGain(taskValue, taskDurationSeconds);

            return $"Person 1 Theoretical Gain: {gain1}\nPerson 2 Theoretical Gain: {gain2}";
        }

        // Additional methods can be added as needed.
    }

}
