using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int DefaultPriority { get; set; }
    }

}
