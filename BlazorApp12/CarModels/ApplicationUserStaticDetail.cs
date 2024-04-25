using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class ApplicationUserStaticDetail
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId { get; set; }  // UserId acts as both PK and FK
        public virtual ApplicationUser ApplicationUser { get; set; }

        // Other static properties here...
        public string PhoneNumber { get; set; }
        public string VehicleArea { get; set; }
        public string ExpertiseCategory { get; set; }

        // Navigation property
        //public ApplicationUser ApplicationUser { get; set; }
    }
}
