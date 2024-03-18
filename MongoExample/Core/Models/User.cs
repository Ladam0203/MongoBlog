using MongoDB.Bson;

namespace MongoExample.Core.Models;

public class UserModel
{
    public string Uuid { get; set; }
    public string Name { get; set; }
    public IEnumerable<ShallowBlog> blogs { get; set; }
} 

public class ShallowUser
{
    public string Uuid { get; set; }
    public string Name { get; set; }
}