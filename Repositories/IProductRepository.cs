using WebBooks.Models;

namespace WebBooks.Repositories;

public interface IProductRepository
{
    Task<List<Product>> GetAllProducts();
    Task<Product> GetProductById(string id);
    Task CreateProduct(Product product);
    Task UpdateProduct(string id, Product product);
    Task DeleteProduct(string id);
}