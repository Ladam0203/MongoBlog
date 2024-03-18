using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoExample.Core.Models;

public class BlogModel
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Guid { get; set; }
    public string Title { get; set; }
    public ShallowUser author { get; set; }
    public IEnumerable<ShallowPost> posts { get; set; }
}

public class ShallowBlog
{
    public Guid Guid { get; set; }
    public string Title { get; set; }
}

public class PostBlogDTO
{
    public string Title { get; set; }
    public ShallowUser Author { get; set; }
}