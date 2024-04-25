namespace BlazorApp1.CarModels
{
    public class UserEventDetailText
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int UserEventDetailId { get; set; }
        public UserEventDetail UserEventDetail { get; set; }
    }
}
