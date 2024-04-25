namespace BlazorApp1.CarModels
{
    public class TicketStats
    {
        public int TotalCount { get; set; }
        public int OpenCount { get; set; }
        public int ClosedCount { get; set; }
        public int HighPriorityCount { get; set; }
        public double AvgTimeToClose { get; set; }

        // Additional stats properties...
    }
}
