using Microsoft.AspNetCore.Identity;


namespace BlazorApp1.CarModels
{

    public class ApplicationUser : IdentityUser //<string>
    {
       // private ApplicationUserDetail? applicationUserDetails;

        public string? FriendlyName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }






        // Navigation Properties no ids required (its FK of ApplicationUser
        public virtual ApplicationUserStaticDetail? ApplicationUserStaticDetail { get; set; }
        //a singular one to one with User, as a sub?-aggregate-root of an already aggregate root?
       public virtual ApplicationUserDetail? ApplicationUserDetails { get; set; }
        // Navigation properties
        public int? TeamId { get; set; }
        public Team? Team { get; set; }



        public virtual ICollection<UserCarEvent> UserCarEvents { get; set; } = new List<UserCarEvent>();

        public virtual ICollection<UserEvent>? UserEvents { get; set; }



    }
}
    //public List<UserCarEvent>? Events { get; set; }

    //gptgen schema
    /*public string Id { get; set; }
    public string UserName { get; set; }
    public string NormalizedUserName { get; set; }
    public string Email { get; set; }
    public string NormalizedEmail { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string ConcurrencyStamp { get; set; }
    public string PhoneNumber { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public DateTimeOffset? LockoutEnd { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public string FriendlyName { get; set; }*/


