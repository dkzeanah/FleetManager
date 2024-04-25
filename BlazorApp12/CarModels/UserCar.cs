using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.CarModels
{
    public class UserCar
    {
        public int UserId { get; set; }
        public int CarId { get; set; }

        // Other properties about the User and Car relationship

        // Navigation properties
        public User User { get; set; }
        public Car Car { get; set; }
    }

}
