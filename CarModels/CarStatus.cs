using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;

public partial class CarStatus
{
    public int Id { get; set; }
    [ForeignKey("NewCar")]
    public int NewCarId { get; set; }

    public int StatusId { get; set; }

    public DateTime? StatusTime { get; set; }

    public virtual NewCar? NewCar { get; set; } 

    public virtual Status? Status { get; set; } 
}
