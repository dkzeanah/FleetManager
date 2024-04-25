using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public class ApplicationUser : IdentityUser //<string>
{
    public virtual IdentityRole? Role { get; set; } = null!;

    public string FriendlyName { get; set; }
    public ApplicationUserDetail? ApplicationUserDetail { get;  set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    //| Navigation Properties
    public int EventId { get; set; }
    public int UserEventId { get; set; }
    public int UserDetailId { get; set; }
    public int UserCarEventId { get; set; }
    public virtual ICollection<Event>? Events { get; set; }
    public virtual ICollection<UserEvent>? UserEvents { get; set; }
    public virtual ICollection<UserDetail> UserDetails { get; set; }
    public virtual ICollection<UserCarEvent> UserCarEvents { get; set; }
    public virtual ICollection<TaskModel> Tasks { get; set; } = new List<TaskModel>();



    //public List<Event>? Events { get; set; }

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

}
