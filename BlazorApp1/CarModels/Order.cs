using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public ShippingInfo ShippingInfo { set; get; }
    }
}
