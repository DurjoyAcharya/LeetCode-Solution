using WebBooks.Models;

namespace WebBooks.Repositories;

public interface IOrderRepository
{
    Task<List<Order>> GetAllOrders();
    Task<Order> GetOrderById(string id);
    Task CreateOrder(Order product);
    Task UpdateOrder(string id, Order product);
    Task DeleteOrder(string id);
}