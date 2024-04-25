using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.CarModels
{
    public class UserLog
    {
        public int UserLogId { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }

        // Navigation property
        public User User { get; set; }
    }

}
