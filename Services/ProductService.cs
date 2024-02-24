using WebBooks.Models;
using WebBooks.Repositories;

namespace WebBooks.Services;

public class ProductService(IProductRepository productRepository) : IProductService
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<List<Product>> GetProducts() => await _productRepository.GetAllProducts();

    public async Task<Product> GetProductById(string id) => await _productRepository.GetProductById(id);

    public async Task CreateProduct(Product product) => await _productRepository.CreateProduct(product);

    public async Task UpdateProduct(string id, Product product) => await _productRepository.UpdateProduct(id, product);

    public async Task DeleteProduct(string id) => await _productRepository.DeleteProduct(id);
}