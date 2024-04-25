using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.CarModels
{
    public class UserStatus
    {
        public int UserId { get; set; }
        public string Status { get; set; }

        // Navigation property
        public User User { get; set; }
    }

}
