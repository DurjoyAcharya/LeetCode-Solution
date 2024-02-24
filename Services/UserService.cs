using WebBooks.Models;
using WebBooks.Repositories;

namespace WebBooks.Services;

public class UserService(IUserRepository repository) : IUserService
{
    private readonly IUserRepository _repository = repository;
    
    public async Task<List<User>> GetUsers() => await _repository.GetAllOrders();

    public async Task<User> GetUserById(string id) => await _repository.GetUserById(id);

    public async Task CreateUser(User user) => await _repository.CreateUser(user);

    public async Task UpdateUser(string id, User user) => await _repository.UpdateUser(id, user);

    public async Task DeleteUser(string id) => await _repository.DeleteUser(id);
}