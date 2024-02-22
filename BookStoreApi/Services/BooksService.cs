using BookStoreApi.Models;
using Microsoft.Extensions.Options;

namespace BookStoreApi.Services;

public class BooksService
{
    private readonly IMongoCollection<Books> _mongoBooksCollection;

    public BooksService(IOptions<BookStoreDatabaseSettings> bookSettings)
    {
        var mongoClient = new MongoDbClient(
            bookSettings.Value.ConnectionString
            );
        var mongoDatabase=mongoClient.
        
    }
}