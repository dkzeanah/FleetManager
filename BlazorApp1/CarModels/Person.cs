using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class Person
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
    }
}
