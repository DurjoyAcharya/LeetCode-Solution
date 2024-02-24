using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebBooks.Models;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public string CategoryId { get; set; } = null!;
}