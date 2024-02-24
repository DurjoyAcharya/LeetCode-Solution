using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebBooks.Models;

public class Order
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string CustomerId { get; set; } = null!;
    public List<Product> Items { get; set; } = null!;
    public User user { get; set; } // Navigation property
    public DateTime OrderDate { get; set; }
}