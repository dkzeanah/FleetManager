namespace BlazorApp1.Interfaces
{
    public interface IReportable
    {
        int ReportId { get; set; }
        DateTime LastTested { get; set; }

        // Common methods...
    }
}
