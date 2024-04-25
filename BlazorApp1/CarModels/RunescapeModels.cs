public class RsUser
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Username { get; set; }
}

// Models/Item.cs
public class Item
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public decimal Price { get; set; } // Simplified for example
}

public enum PriceOption
{
    FreeForm, MarketPricePlus5, MarketPriceMinus5
}
// Models/ExchangeOffer.cs
public class ExchangeOffer
{
    //internal int SelectedPriceOption;
    public PriceOption SelectedPriceOption { get; set; } // New property

    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid UserId { get; set; }
    public Guid ItemId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public bool IsBuyOffer { get; set; } // true for buy, false for sell
    public string OfferType => IsBuyOffer ? "Buying" : "Selling";

}