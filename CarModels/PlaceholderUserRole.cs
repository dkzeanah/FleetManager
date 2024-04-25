using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class PlaceholderUserRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<PlaceholderUser> PlaceholderUsers { get; set; } = new List<PlaceholderUser>();
}
