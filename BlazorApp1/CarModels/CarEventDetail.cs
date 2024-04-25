using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class CarEventDetail : IEventDetail
    {
        public int GetDetailId() => CarEventDetailId;
        public string? GetNote() => Note;

        [Key]
        public int CarEventDetailId { get; set; }
        public int? CarEventId { get; set; }
        public virtual string? Note { get; set; }
        public virtual CarEvent? CarEvent { get; set; }

        //public int CarEventDetailId { get; set; }
        //public required string DetailType { get; set; }
        /* public int EventId { get; set; }
         public int CarDetailId { get; set; }
         public Event Event { get; set; }
         public CarDetail CarDetails { get; set; }*/
    }
}
