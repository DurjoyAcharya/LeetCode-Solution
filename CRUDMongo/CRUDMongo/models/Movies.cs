using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CRUDMongo.models;

public class Movies
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; } // Primary key (usually auto-incremented)
    [BsonElement("name")]
    public string? Title { get; set; } = null;
    public string? Genre { get; set; } = null;
    public int ReleaseYear { get; set; }
}