using BlazorApp1.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public  class PlaceholderUser : IdentityUser
{
    //public int UserId { get; set; }

   // public string Username { get; set; } = null!;

   // public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual PlaceholderUserRole Role { get; set; } = null!;
    public ApplicationUserDetail? PlaceholderUserDetail { get; internal set; }
}
