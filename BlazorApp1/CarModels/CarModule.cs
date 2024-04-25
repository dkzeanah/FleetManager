using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class CarModule
    {
        
        public int CarId { get; set; }
        public int ModuleId { get; set; }
        public Car? Car {  get; set; }
        public Module? Module { get; set; }

    }
}
