using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class ApplicationUserDetail
    {
        [Key]
        public required string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;         // Other properties here...

        public static implicit operator ApplicationUserDetail(ApplicationUser v)
        {
            throw new NotImplementedException();
        }
    }
}
