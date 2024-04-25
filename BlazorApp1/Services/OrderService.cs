using BlazorApp1.CarModels;
using BlazorApp1.Interfaces;
namespace BlazorApp1.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task CreateOrder(Order order)
        => _orderRepository.CreateOrder(order);

    public Task<Order> GetOrderDetails(Guid orderId)
        => _orderRepository.GetOrderDetails(orderId);

    public Task<List<Order>> GetOrdersForUser(Guid userId)
        => _orderRepository.GetOrdersForUser(userId);

    public Task UpdateOrderStatus(Guid orderId, bool isPaymentComplted)
        => _orderRepository.UpdateOrderStatus(orderId, isPaymentComplted);

    /*Task<List<Order>> IOrderService.GetOrdersForUser(Guid userId)
    {
        throw new NotImplementedException();
    }*/


}
