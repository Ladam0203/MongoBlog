namespace MongoExample.Core.Models;

public class CommentModel
{
    public string Uuid { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public ShallowPost post { get; set; }
    public ShallowUser author { get; set; }
}