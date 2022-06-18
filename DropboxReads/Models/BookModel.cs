using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DropboxReads.Models;

public class Book
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string? Title { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string>? AuthorIds { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string>? TagIds { get; set; }
}