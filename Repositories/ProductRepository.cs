using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Configurations;
using WebBooks.Models;

namespace WebBooks.Repositories;

public class ProductRepository:IProductRepository
{
    private readonly IMongoCollection<Product> _collection;

    public ProductRepository(IOptions<DbSettings> settings)
    {
        var mongoClient = new MongoClient(
            settings.Value.ConnectionString
            );
        var database = mongoClient.GetDatabase(settings.Value.DatabaseName);
        _collection = database.GetCollection<Product>(settings.Value.ProductCollectionName);
    }

    public async Task<List<Product>> GetAllProducts() => await _collection.Find(_ => true).ToListAsync()!;


    public async Task<Product> GetProductById(string id) => await _collection.Find(_ => _.Id == id).FirstOrDefaultAsync();

    public async Task CreateProduct(Product product) => await _collection.InsertOneAsync(product);

    public async Task UpdateProduct(string id, Product product) =>
        await _collection.ReplaceOneAsync(x => x.Id == id, product);

    public async Task DeleteProduct(string id)=>await _collection.DeleteOneAsync(x => x.Id == id);
    
}