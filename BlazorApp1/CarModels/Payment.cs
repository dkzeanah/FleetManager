namespace BlazorApp1.CarModels
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Amount { get; set; }
        // You can add more properties as needed
    }
}
