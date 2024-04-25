using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;
[Table("CarStaticDetail")]

public partial class CarStaticDetail
{

    //Required
    public int Id { get; set; }
    public string Vin { get; set; }
    public string Tag { get; set; } = null!;
    public string Finas { get; set; } = null!;


    public bool? Adas { get; set; }



    // Navigation Properties
    public int? CarId { get; set; }
    public virtual NewCar Car { get; set; }

    // TODO: carstatus should have this: public string? SoftwareVersion { get; set; }
    //public string? Detail { get; internal set; }
}


