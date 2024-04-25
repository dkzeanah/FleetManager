using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class TicketCategory
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public int DefaultPriority { get; set; }
    }

}
