using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoExample.Core.Models;

public class PostModel
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Guid { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public ShallowBlog blog { get; set; }
    public ShallowUser author { get; set; }
    public IEnumerable<CommentModel> comments { get; set; } 
}

public class ShallowPost
{
    public Guid Guid { get; set; }
    public string Title { get; set; }
}

public class PostPostDTO
{
    public string Title { get; set; }
    public string Content { get; set; }
    public ShallowBlog Blog { get; set; }
    public ShallowUser Author { get; set; }
}