namespace BlazorApp1.CarModels
{
    public class ShippingInfo
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public List<Shipment> Shipments { get; } = new();
        public List<Delivery> Deliveries { get; } = new();
    }

    
}
