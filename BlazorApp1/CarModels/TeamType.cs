namespace BlazorApp1.CarModels
{
    public class TeamType
    {
        public int TeamTypeId { get; set; }
        public string Name { get; set; }
        public TeamTimeline TeamTimeline { get; set; }
        public ICollection<ApplicationUser> TeamMembers { get; set; }
    }
}
