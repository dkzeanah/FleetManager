using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class ApplicationUserStaticDetail
{
    public string Id { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string VehicleArea { get; set; } = null!;

    public string ExpertiseCategory { get; set; } = null!;

    public virtual ApplicationUser IdNavigation { get; set; } = null!;
}
