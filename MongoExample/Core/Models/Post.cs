namespace MongoExample.Core.Models;

public class PostModel
{
    public string Uuid { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public ShallowBlog blog { get; set; }
    public ShallowUser author { get; set; }
    public IEnumerable<CommentModel> comments { get; set; } 
}

public class ShallowPost
{
    public string Uuid { get; set; }
    public string Title { get; set; }
}