namespace BlazorApp1.CarModels
{
    public class Worker
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public List<Tool> EquippedTools { get; private set; } = new List<Tool>();

        public void EquipTool(Tool tool)
        {
            EquippedTools.Add(tool);
        }
        public decimal CalculateEarnings(decimal hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }
    }

}
