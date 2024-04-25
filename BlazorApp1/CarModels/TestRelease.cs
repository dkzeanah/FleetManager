using BlazorApp1.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class TestRelease : IReportable
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? CalendarWeek { get; set; }
        public int? CalendarMonth { get; set; }
        public int? CalendarYear { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<Car> Cars { get; set; }
        public List<ApplicationUser>? Users { get; set; }
        //reportables
        public int ReportId { get; set; }
        public DateTime LastTested { get; set; }
        public ICollection<CheckListItem> CheckListItems { get; set; } // CheckListItems associated with this test release

    }
}
