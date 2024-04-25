using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class Blank
    {

        [Key]
        public int Id { get; set; }
        public string String { get; set; }
        public string Name { get; set; }
    }
}
