using WebBooks.Models;

namespace WebBooks.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllCategory();
    Task<Category> GetCategoryById(string id);
    Task CreateCategory(Category category);
    Task UpdateCategory(string id, Category category);
    Task DeleteCategory(string id);
}