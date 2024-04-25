
using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces;

public interface IOrderService
{
    Task<List<Order>> GetOrdersForUser(Guid userId);   
}
