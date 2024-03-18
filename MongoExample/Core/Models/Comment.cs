namespace MongoExample.Core.Models;

public class CommentModel
{
    public Guid Guid { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public ShallowPost post { get; set; }
    public ShallowUser author { get; set; }
}