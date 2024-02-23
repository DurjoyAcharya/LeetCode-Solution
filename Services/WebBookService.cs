using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Models;

namespace WebBooks.Services;

public class WebBookService
{
    private readonly IMongoCollection<Book> _bookCollection;

    public WebBookService(IOptions<WebBookSettings> bOptions)
    {
        var mongoClient = new MongoClient(bOptions.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(bOptions.Value.DatabaseName);
        _bookCollection = mongoDatabase.GetCollection<Book>(bOptions.Value.BooksCollectionName);
    }
}