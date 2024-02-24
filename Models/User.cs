using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebBooks.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
}