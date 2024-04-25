using System;
using System.Collections.Generic;

namespace BlazorApp1.CarModels;

public partial class Logger
{
    public int Id { get; set; }
    
    public int TruckId { get; set; }
    public int NewCarId { get; set; }

    public string TypeLogger { get; set; } = null!;

    public int NumLoggers { get; set; }

    public virtual Truck? Truck { get; set; } 
    public virtual NewCar? NewCar { get; set; } 
}
