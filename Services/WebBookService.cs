using Microsoft.Extensions.Options;
using MongoDB.Driver;
using WebBooks.Models;

namespace WebBooks.Services;

//Main Service file 
public class WebBookService
{
    private readonly IMongoCollection<Book> _bookCollection;

    public WebBookService(IOptions<WebBookSettings> bOptions)
    {
        var mongoClient = new MongoClient(
            bOptions.Value.ConnectionString);//firstly connect to the db using connection string
        var mongoDatabase = mongoClient.GetDatabase(
            bOptions.Value.DatabaseName);//then connect to the database name 
        _bookCollection = mongoDatabase.GetCollection<Book>(
            bOptions.Value.BooksCollectionName);//then connect to the collection apmr
    }

    //get all list of books 
    public async Task<List<Book>> GetAsync() => await _bookCollection.Find(_ => true).ToListAsync();

    public async Task<Book?> GetBookInfo(string id) =>
        await _bookCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
    

}