using WebBooks.Models;
using WebBooks.Repositories;

namespace WebBooks.Services;

public class OrderService(IOrderRepository orderRepository) : IOrderService
{
    private readonly IOrderRepository _orderRepository = orderRepository;

    public async Task<List<Order>> GetOrders() => await _orderRepository.GetAllOrders();

    public async Task<Order> GetOrderById(string id) => await _orderRepository.GetOrderById(id);

    public async Task CreateOrder(Order product) => await _orderRepository.CreateOrder(product);

    public async Task UpdateOrder(string id, Order product) => await _orderRepository.UpdateOrder(id, product);

    public async Task DeleteOrder(string id) => await _orderRepository.DeleteOrder(id);

}