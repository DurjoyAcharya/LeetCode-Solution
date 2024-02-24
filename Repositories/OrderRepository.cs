using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Configurations;
using WebBooks.Models;

namespace WebBooks.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly IMongoCollection<Order> _collection;

    public OrderRepository(IOptions<DbSettings> settings)
    {
        var connectionString = new MongoClient(
            settings.Value.ConnectionString
        );
        var database = connectionString.GetDatabase(settings.Value.DatabaseName);
        _collection = database.GetCollection<Order>(settings.Value.OrderCollectionName);
    }
    public async Task<List<Order>> GetAllOrders() => await _collection.Find(_ => true).ToListAsync();
    
    public async Task<Order> GetOrderById(string id) => await _collection.Find(_ => _.Id == id).FirstOrDefaultAsync();

    public async Task CreateOrder(Order product) => await _collection.InsertOneAsync(product);

    public async Task UpdateOrder(string id, Order product) =>
        await _collection.ReplaceOneAsync(_ => _.Id == id, product);

    public async Task DeleteOrder(string id) => await _collection.DeleteOneAsync(_ => _.Id == id);
}