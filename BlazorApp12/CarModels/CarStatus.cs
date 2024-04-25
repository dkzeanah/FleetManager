
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels
{
    public partial class CarStatus
    {
        [Key]
        public int Id { get; set; }
        //Nav Ids
        public int CarId { get; set; }
        public int StatusId { get; set; }
        //Nav Entities
        public virtual Car Car { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public DateTime? StatusTime { get; set; }

    }
}