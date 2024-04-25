using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class CarEventDetail
    {
        [Key]
        public int Id { get; set; }
        public int CarEventId { get; set; }
        public string Note { get; set; }
        public CarEvent CarEvent { get; set; }

        //public int CarEventDetailId { get; set; }
        //public required string DetailType { get; set; }
        /* public int EventId { get; set; }
         public int CarDetailId { get; set; }
         public UserCarEvent UserCarEvent { get; set; }
         public CarDetail CarDetails { get; set; }*/
    }
}
