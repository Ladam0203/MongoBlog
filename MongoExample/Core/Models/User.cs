using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoExample.Core.Models;

public class UserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public IEnumerable<ShallowBlog> blogs { get; set; }
} 

public class ShallowUser
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
}

public class PostUserDTO
{
    public string Name { get; set; }
}