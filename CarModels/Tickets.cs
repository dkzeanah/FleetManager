namespace BlazorApp1.CarModels
{
    public class Ticket
    {
        public int Id { get; set; }  // Unique identifier for the ticket
        public string Title { get; set; }  // The title of the ticket
        public string Description { get; set; }  // Detailed description of the issue
        public string CreatorId { get; set; }  // The ID of the user who created the ticket
        public ApplicationUser Creator { get; set; }  // The user who created the ticket
        public string AssigneeId { get; set; }  // The ID of the user who is assigned to the ticket
        public ApplicationUser Assignee { get; set; }  // The user who is assigned to the ticket
        public DateTime CreatedAt { get; set; }  // When the ticket was created
        public DateTime? UpdatedAt { get; set; }  // When the ticket was last updated
        public DateTime? ClosedAt { get; set; }  // When the ticket was closed
        public string Status { get; set; }  // The current status of the ticket (e.g., "Open", "In Progress", "Closed")
        public string Severity { get; set; }  // The severity of the issue (e.g., "Low", "Medium", "High", "Critical")
        public string Priority { get; set; }  // The priority of the ticket (e.g., "Low", "Medium", "High")
        public ICollection<TicketComment> Comments { get; set; }  // Comments on the ticket
        public ICollection<TicketAttachment> Attachments { get; set; }  // Files attached to the ticket
        public ICollection<TicketTag> Tags { get; set; }  // Tags associated with the ticket
        public ICollection<TicketHistory> History { get; set; }  // History of changes on the ticket
    }
}
