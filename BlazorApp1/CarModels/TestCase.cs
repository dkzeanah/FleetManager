using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class CarTestCase
    {
        [Key]
        public int Id { get; set; } 
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int? ModuleId { get; set; } 
        public List<String> Instructions { get; set; }
        public Status Status { get; set; }
        public bool HasBeenTested { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsDeleted { get; set; }

    }
}
