public class CompletedTrade
{
    public Guid BuyerId { get; set; }
    public Guid SellerId { get; set; }
    public Guid ItemId { get; set; }
    public decimal TradePrice { get; set; }
    public int Quantity { get; set; }
}