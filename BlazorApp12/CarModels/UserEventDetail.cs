namespace BlazorApp1.CarModels
{
    public partial class UserEventDetail
    {
        public int Id { get; set; }
        //
        public int? CarId { get; set; }
        public Car? Car { get; set; }
        //
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public int? UserEventId { get; set; }
        public UserEvent? UserEvent { get; set; }

        public int? UserEventDetailGrandularId { get; set; }

        public string? Information { get; set; }

        public ICollection<UserEventDetailText>? Text { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
