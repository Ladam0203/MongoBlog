namespace MongoExample.Core.Models;

public class BlogModel
{
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