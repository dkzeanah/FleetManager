using System.ComponentModel.DataAnnotations;

public class DateRange
{
    [Required]
    [DataType(DataType.Date)]
    public DateTime Start { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime End { get; set; }
}