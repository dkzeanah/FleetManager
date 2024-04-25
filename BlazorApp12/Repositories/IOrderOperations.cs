using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface IOrderOperations
    {
        Task<Order> GetOrderById(int id);
        Task<Order> AddDeliveryToOrder(int id, Delivery delivery);
        Task<Order> AddOrder(Order order);
    }
}
