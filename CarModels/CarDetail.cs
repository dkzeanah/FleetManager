using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public partial class CarDetail
    {
        [Key]
        public int CarId { get; set; }

        public string? Tag { get; set; } = null!;

        public string? Finas { get; set; } = null!;

        public string? VinLast4 { get; set; } = null!;

        public string? HarnessStatus { get; set; }

        public string? FullVin { get; set; }

        public string? SoftwareVersion { get; set; }

        public string? Adas { get; set; }

        public virtual Car Car { get; set; } = null!;
    }
}