using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;
//[Table("TruckStaticDetail")]

public partial class TruckStaticDetail
{
     
    //Required
    //public int Id { get; set; }
    public string Vin { get; set; }
    public string Tag { get; set; } = null!;
    public string Finas { get; set; } = null!;


    public bool? Adas { get; set; }



    // Navigation Properties
    //[ForeignKey(nameof(TruckId))]
   // public int TruckId { get; set; }
   // public virtual Truck Truck { get; set; }

    // TODO: carstatus should have this: public string? SoftwareVersion { get; set; }
    //public string? Detail { get; internal set; }
}
