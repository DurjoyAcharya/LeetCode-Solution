using WebBooks.Models;

namespace WebBooks.Services;

public interface IOrderService
{
    Task<List<Order>> GetOrders();
    Task<Order> GetOrderById(string id);
    Task CreateOrder(Order product);
    Task UpdateOrder(string id, Order product);
    Task DeleteOrder(string id);
}