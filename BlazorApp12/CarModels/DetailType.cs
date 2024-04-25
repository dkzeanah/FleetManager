using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.CarModels
{
    [Table("DetailType")]

    public class DetailType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        //Navigation Properties
        //public virtual ICollection<Detail> Details { get; set; }

    }
}
