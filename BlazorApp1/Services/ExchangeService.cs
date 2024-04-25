using BlazorApp1.Data;
using Microsoft.SqlServer.Management.Smo;

namespace BlazorApp1.Services
{
    // Services/ExchangeService.cs
    public class ExchangeService
    {

        // Assuming you already have a list to store offers
        private List<ExchangeOffer> _offers = new List<ExchangeOffer>();

        // Public property to access the offers
        public List<ExchangeOffer> Offers => _offers;

        private readonly ILogger<ExchangeService> _logger;

        public ExchangeService(ILogger<ExchangeService> logger)
        {
            _logger = logger;
        }

        public void AddRsUser(RsUser user)
        {
            ExchangeData.Users.Add(user);
        }

        public void AddItem(Item item)
        {
            ExchangeData.Items.Add(item);
        }

        public void AddOffer(ExchangeOffer offer)
        {
            _logger.LogInformation("Adding offer: {OfferDetails}", offer);

            // Adjust price based on the selected option (if any)
            var item = ExchangeData.Items.FirstOrDefault(i => i.Id == offer.ItemId);
            if (item != null)
            {
                // Assuming you have a field in ExchangeOffer to store the selected option
                switch (offer.SelectedPriceOption)
                {
                    case PriceOption.MarketPricePlus5:
                        offer.Price = item.Price * 1.05m;
                        break;
                    case PriceOption.MarketPriceMinus5:
                        offer.Price = item.Price * 0.95m;
                        break;
                        // No adjustment for free-form value
                }
            }
            // In a real-world scenario, you would include logic here to match buy and sell offers.
            _offers.Add(offer);
            CheckForTrades(offer);
            _logger.LogInformation("Offer added and trades checked.");

        }
        public List<CompletedTrade> CompletedTrades = new List<CompletedTrade>();
        
        private void CheckForTrades(ExchangeOffer newOffer)
        {
            _logger.LogInformation("Checking for trades for offer: {OfferId}", newOffer.Id);

            var potentialMatches = _offers // Ensure you are checking the correct list
                .Where(o => o.ItemId == newOffer.ItemId && o.IsBuyOffer != newOffer.IsBuyOffer)
                .ToList();

            foreach (var match in potentialMatches)
            {
                if ((newOffer.IsBuyOffer && newOffer.Price >= match.Price) ||
                    (!newOffer.IsBuyOffer && newOffer.Price <= match.Price))
                {
                    var tradePrice = (newOffer.Price + match.Price) / 2; // Average price
                    var item = ExchangeData.Items.First(i => i.Id == newOffer.ItemId);

                    // Creating a completed trade
                    var completedTrade = new CompletedTrade
                    {
                        
                        BuyerId = newOffer.IsBuyOffer ? newOffer.UserId : match.UserId,
                        SellerId = newOffer.IsBuyOffer ? match.UserId : newOffer.UserId,
                        ItemId = newOffer.ItemId,
                        TradePrice = tradePrice,
                        Quantity = Math.Min(newOffer.Quantity, match.Quantity) // Assuming partial trades are allowed
                    };
                        // ... Trade details
                    

                    CompletedTrades.Add(completedTrade);
                    item.Price = AdjustMarketPrice(item.Price, tradePrice);

                    // Remove the matched offers from the correct list
                    _offers.Remove(newOffer);
                    _offers.Remove(match);

                    break; // Exit the loop after processing the first match
                }
            }

        }

        private decimal AdjustMarketPrice(decimal currentPrice, decimal tradePrice)
        {
            // Simplified logic to adjust price based on supply and demand
            if (tradePrice > currentPrice)
            {
                // Increase price slightly to simulate demand
                return currentPrice * 1.05m; // Increase by 5%
            }
            else
            {
                // Decrease price slightly to simulate supply
                return currentPrice * 0.95m; // Decrease by 5%
            }
        }
        
        public List<RsUser> GetUsers() => ExchangeData.Users;
        public List<Item> GetItems() => ExchangeData.Items;
        public List<ExchangeOffer> GetOffers() => ExchangeData.Offers;

    }

}
