using CRUDMongo.models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CRUDMongo.Services;

public class MoviesService
{
    private readonly IMongoCollection<Movies> _moviesCollection;
    public MoviesService(
        IOptions<MovieDatabaseSettings> moviesStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            moviesStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            moviesStoreDatabaseSettings.Value.DatabaseName);

        _moviesCollection = mongoDatabase.GetCollection<Movies>(
            moviesStoreDatabaseSettings.Value.MoviesCollectionName);
    }
    public async Task<List<Movies>> GetAsync() =>
        await _moviesCollection.Find(_ => true).ToListAsync();

    public async Task<Movies?> GetAsync(string id) =>
        await _moviesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(Movies newMovies) =>
        await _moviesCollection.InsertOneAsync(newMovies);

    public async Task UpdateAsync(string id, Movies updatedMovies) =>
        await _moviesCollection.ReplaceOneAsync(x => x.Id == id, updatedMovies);

    public async Task RemoveAsync(string id) =>
        await _moviesCollection.DeleteOneAsync(x => x.Id == id);
}