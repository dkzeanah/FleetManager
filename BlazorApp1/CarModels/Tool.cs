namespace BlazorApp1.CarModels
{
    public class Tool
    {
        public string Name { get; set; }

        public decimal Cost { get; set; }
        public decimal EfficiencyMultiplier { get; set; }

        public Tool(string name, decimal cost, decimal efficiencyMultiplier)
        {
            Name = name;
            Cost = cost;
            EfficiencyMultiplier = efficiencyMultiplier;
        }
        public void AdjustEfficiency(decimal timeWithoutTool, decimal timeWithTool)
        {
            if (timeWithoutTool > 0)
            {
                EfficiencyMultiplier = timeWithTool / timeWithoutTool;
            }
            else
            {
                throw new InvalidOperationException("Time without tool must be greater than zero.");
            }
        }
    }
}

