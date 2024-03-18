using MongoDB.Bson;

namespace MongoExample.Core.Models;

public class UserModel
{
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