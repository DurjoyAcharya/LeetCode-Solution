using WebBooks.Models;

namespace WebBooks.Services;

public interface IUserService
{
    Task<List<User>> GetUsers();
    Task<User> GetUserById(string id);
    Task CreateUser(User user);
    Task UpdateUser(string id, User user);
    Task DeleteUser(string id);
}