namespace BlazorApp1.CarModels
{
    public abstract class Detail
    {
        public int Id { get; set; }
        public int DetailTypeId{ get; set; }
        public string Value { get; set; }
        //navigation properties
        public DetailType DetailType { get; set; }
        public string? ApplicationUserId { get; set; } // This is the new property

        // Navigation property
        public ApplicationUser? ApplicationUser { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<CarDetail> CarDetails { get; set; }
        public virtual ICollection<EventDetail> EventDetails { get; set; }
    }
}
