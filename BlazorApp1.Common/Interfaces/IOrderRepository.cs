using BlazorApp1.CarModels;

namespace BlazorApp1.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> AddDeliveryToOrder(int id, Delivery delivery);
        Task<Order> GetOrderById(int id);
        Task<Order> AddOrder(Order order);
        Task UpdateOrderStatus(Guid orderId, bool isPaymentComplted);
        Task<List<Order>> GetOrdersForUser(Guid userId);
        Task<Order> GetOrderDetails(Guid orderId);
        Task CreateOrder(Order order);
    }
}