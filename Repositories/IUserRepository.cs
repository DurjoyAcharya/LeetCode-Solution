using WebBooks.Models;

namespace WebBooks.Repositories;

public interface IUserRepository
{
    Task<List<User>> GetAllOrders();
    Task<User> GetUserById(string id);
    Task CreateUser(User user);
    Task UpdateUser(string id, User user);
    Task DeleteUser(string id);
}