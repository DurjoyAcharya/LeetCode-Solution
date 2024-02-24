using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Configurations;
using WebBooks.Models;

namespace WebBooks.Repositories;

public class UserRepository:IUserRepository
{
    private readonly IMongoCollection<User> _collection;

    public UserRepository(IOptions<DbSettings> settings)
    {
        var mongoClient = new MongoClient(
            settings.Value.ConnectionString
        );
        var database = mongoClient.GetDatabase(settings.Value.DatabaseName);
        _collection = database.GetCollection<User>(settings.Value.UserCollectionName);
    }
    public async Task<List<User>> GetAllOrders() => await _collection.Find(_ => true).ToListAsync();

    public async Task<User> GetUserById(string id) => await _collection.Find(_ => _.Id == id).FirstOrDefaultAsync();

    public async Task CreateUser(User user) => await _collection.InsertOneAsync(user);

    public async Task UpdateUser(string id, User user) => await _collection.ReplaceOneAsync(_ => _.Id == id, user);

    public async Task DeleteUser(string id) => await _collection.DeleteOneAsync(_ => _.Id == id);
}