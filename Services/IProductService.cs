using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Models;
//using WebBooks.Models;
using WebBooks.Repositories;

namespace WebBooks.Services;

public interface IProductService{
    Task<List<Product>> GetProducts();
    Task<Product> GetProductById(string id);
    Task CreateProduct(Product product);
    Task UpdateProduct(string id, Product product);
    Task DeleteProduct(string id);
}