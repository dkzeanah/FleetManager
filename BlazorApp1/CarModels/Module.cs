using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels;

public class Module
{
    // Enum for TypeLogger
   
    [Key]
    public int ModuleId { get; set; }
    public int? CarId { get; set; }
    public ICollection<Car>? Cars { get; set; }
    public List<CarModule>? CarModules { get; set; }

    public string Name { get; set; }
    public string? Description { get; set; }
    public double? CurrentSoftwareVersion { get; set; }
    public double? NextSoftwareVersion { get; set; }
    public DateTime? LastUpdated { get; set; }
    public DateTime? ProjectedRelease { get; set; }

    [NotMapped]
    public bool IsEditing { get; set; } = false;


}
