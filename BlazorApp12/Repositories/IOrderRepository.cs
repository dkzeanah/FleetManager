using BlazorApp1.CarModels;

namespace BlazorApp1.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> AddDeliveryToOrder(int id, Delivery delivery);
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);

    }
}