namespace BlazorApp1.CarModels
{
  public class PaymentInfo
  {
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime StartDate { get; set; }
    public int FrequencyInMonths { get; set; } // Frequency of the recurring payment
  }

}
