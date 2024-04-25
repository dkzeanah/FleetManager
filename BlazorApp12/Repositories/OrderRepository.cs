using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Order> AddDeliveryToOrder(int id, Delivery delivery)
        {
            var order = await GetOrderById(id);
            if (order != null)
            {
                order.ShippingInfo.Deliveries.Add(delivery);
                await _context.SaveChangesAsync();
                return order; // Return the added order
            }
            return null;
        }
        public async Task<Order> AddOrder(Order order)
        {
            // Set the order date
            order.OrderDate = DateTime.Now;

            // Add the order to the database
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            // Log the details of the saved entities
            Console.WriteLine($"Saved order with ID {order.Id}, CustomerName {order.CustomerName}, OrderDate {order.OrderDate}");
            Console.WriteLine($"Shipping Info: Address {order.ShippingInfo.Address}, City {order.ShippingInfo.City}, State {order.ShippingInfo.State}, PostalCode {order.ShippingInfo.PostalCode}");
            foreach (var delivery in order.ShippingInfo.Deliveries)
            {
                Console.WriteLine($"Saved delivery with ReceiverName {delivery.ReceiverName}, DeliveryDate {delivery.DeliveryDate}, Signature {delivery.Signature}");
            }

            return order; // Return the added order
        }
        // TODO: Temporary swap
        /*private readonly CalendarDbContext _context;

        public OrderRepository(CalendarDbContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await _context.Orders.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Order> AddDeliveryToOrder(int id, Delivery delivery)
        {
            var order = await GetOrderById(id);
            if (order != null)
            {
                order.ShippingInfo.Deliveries.Add(delivery);
                await _context.SaveChangesAsync();
                return order; // Return the added order
            }
            return null;
        }
        public async Task<Order> AddOrder(Order order)
        {
            // Set the order date
            order.OrderDate = DateTime.Now;

            // Add the order to the database
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            // Log the details of the saved entities
            Console.WriteLine($"Saved order with ID {order.Id}, CustomerName {order.CustomerName}, OrderDate {order.OrderDate}");
            Console.WriteLine($"Shipping Info: Address {order.ShippingInfo.Address}, City {order.ShippingInfo.City}, State {order.ShippingInfo.State}, PostalCode {order.ShippingInfo.PostalCode}");
            foreach (var delivery in order.ShippingInfo.Deliveries)
            {
                Console.WriteLine($"Saved delivery with ReceiverName {delivery.ReceiverName}, DeliveryDate {delivery.DeliveryDate}, Signature {delivery.Signature}");
            }

            return order; // Return the added order
        }
*/
        // Add other order-related methods as needed
    }

}
