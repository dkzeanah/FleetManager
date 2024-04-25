using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels;

public partial class ErrorLog
{
    [Key]
    public int Id { get; set; }

    public int CarId { get; set; }

    public string? ErrorDetails { get; set; }

    public int? ErrorPriority { get; set; }

    public string? ErrorNotes { get; set; }
}
