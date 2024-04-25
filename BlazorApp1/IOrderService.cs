
using BlazorApp1.CarModels;

namespace CodeMazeShop.WebClient.Services;

public interface IOrderService
{
    Task<List<Order>> GetOrdersForUser(Guid userId);   
}
