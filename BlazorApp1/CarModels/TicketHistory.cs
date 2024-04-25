namespace BlazorApp1.CarModels
{
    public class TicketHistory
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public string Change { get; set; }
        public DateTime ChangedAt { get; set; }
        public string ChangedById { get; set; }
        public ApplicationUser ChangedBy { get; set; }
    }
}
