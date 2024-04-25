namespace BlazorApp1.CarModels
{
    public class Job<TJobAttribute>
    {
        //public TJobAttribute JobAttribute { get; set; }
        //public decimal TimeTakenWithoutTool { get; set; }
        //public decimal TimeTakenWithTool { get; set; }
        //public List<decimal> TimeRecords { get; private set; } = new List<decimal>();
        //public int NumberOfScrews { get; set; }
        // public decimal TimeTakenWithoutTool { get; set; } // in hours
        //public decimal TimeTakenWithTool { get; set; } // in hours

        //public Job(int numberOfScrews, decimal timeTakenWithoutTool)
        //{
        //    NumberOfScrews = numberOfScrews;
        //    TimeTakenWithoutTool = timeTakenWithoutTool;
        //}
        public TJobAttribute JobAttribute { get; set; }
        public decimal TimeTakenWithoutTool { get; set; }
        public decimal TimeTakenWithTool { get; set; }
        public List<Tool> ToolsUsed { get; private set; } = new List<Tool>();
        public List<string> MaterialsRequired { get; private set; } = new List<string>();
        public List<JobStep> Steps { get; private set; } = new List<JobStep>();
        public List<decimal> TimeRecords { get; private set; } = new List<decimal>();
        public int NumberOfScrews { get; set; }

        public Job() { }
        public decimal CalculateTimeSaved(Tool tool)
        {
            TimeTakenWithTool = TimeTakenWithoutTool * tool.EfficiencyMultiplier;
            return TimeTakenWithoutTool - TimeTakenWithTool;
        }
        public Job(TJobAttribute jobAttribute, decimal timeTakenWithoutTool)
        {
            JobAttribute = jobAttribute;
            TimeTakenWithoutTool = timeTakenWithoutTool;
        }

        public void PerformJob(Worker worker)
        {
            decimal efficiencyMultiplier = 1m; // Start with no efficiency gain
            foreach (var tool in worker.EquippedTools)
            {
                efficiencyMultiplier *= tool.EfficiencyMultiplier;
            }

            TimeTakenWithTool = TimeTakenWithoutTool * efficiencyMultiplier;
            TimeRecords.Add(TimeTakenWithTool);
        }


        public decimal CalculateRunningAverage()
        {
            if (TimeRecords.Count == 0)
            {
                return 0m;
            }

            decimal total = TimeRecords.Sum();
            return total / TimeRecords.Count;
        }
        //public Job(TJobAttribute jobAttribute, decimal timeTakenWithoutTool)
        //{
        //    JobAttribute = jobAttribute;
        //    TimeTakenWithoutTool = timeTakenWithoutTool;
        //}

        public void AddTool(Tool tool)
        {
            if (tool == null)
            {
                throw new ArgumentNullException(nameof(tool), "Tool cannot be null.");
            }
            ToolsUsed.Add(tool);
        }

        public void AddMaterial(string material)
        {
            if (string.IsNullOrWhiteSpace(material))
            {
                throw new ArgumentException("Material cannot be null or empty.", nameof(material));
            }
            MaterialsRequired.Add(material);
        }

        public void AddStep(JobStep step)
        {
            if (step == null)
            {
                throw new ArgumentNullException(nameof(step), "Step cannot be null.");
            }
            Steps.Add(step);
        }

        //public void PerformJob(Worker worker)
        //{
        //    try
        //    {
        //        // Logic to perform the job with tools and steps
        //        // Calculate time with tools
        //        TimeTakenWithTool = CalculateTimeWithTools();
        //        TimeRecords.Add(TimeTakenWithTool);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle and log the exception
        //        Console.WriteLine($"Error performing job: {ex.Message}");
        //    }
        //}

        private decimal CalculateTimeWithTools()
        {
            decimal efficiencyMultiplier = ToolsUsed.Any() ? ToolsUsed.Average(t => t.EfficiencyMultiplier) : 1;
            return TimeTakenWithoutTool * efficiencyMultiplier;
        }

        //public decimal CalculateRunningAverage()
        //{
        //    return TimeRecords.Count > 0 ? TimeRecords.Average() : 0;
        //}

    }
}
