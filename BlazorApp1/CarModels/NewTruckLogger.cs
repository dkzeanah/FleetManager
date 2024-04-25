using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels;

public partial class NewTruckLogger
{
    // Enum for TypeLogger
    public enum LoggerType
    {
        BluePirate,
        BluePirateRapid,
        X2e
    }
    [Key]
    public int Id { get; set; }

    public int? TruckId { get; set; }
    public int? CarId { get; set; }
    public int? NewCarId { get; set; }

    // Setting default value using property initializer
    public LoggerType TypeLogger { get; set; } = LoggerType.BluePirate;  // Default to Type1


    public int NumLoggers { get; set; } = 1;

    public virtual Truck? Truck { get; set; } 
    public virtual NewCar? NewCar { get; set; }
    public virtual Car? Car { get; set; }
    // Using constructor to set default values
    public NewTruckLogger()
    {
        // This will override the property initializer if set
        TypeLogger = LoggerType.BluePirate;  // Default to Type1

        // You can set other default values here too
    }
}
