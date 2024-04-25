using BlazorApp1.Interfaces;

namespace BlazorApp1.CarModels
{
    public class HealthCheck : IReportable
    {
        //reportables
       //public int Id { get; set; }
        public DateTime LastTested { get; set; }
        public ICollection<CheckListItem> CheckListItems { get; set; } // CheckListItems associated with this car
        public int ReportId { get; set; }
    }
}
