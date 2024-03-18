using MongoExample.Core.Models;
using MongoExample.Core.Repositories;

namespace MongoExample.Core.Services;

public class BlogService
{
    private readonly BlogRepository _repository;
    
    public BlogService(BlogRepository repository)
    {
        _repository = repository;
    }
    
    public BlogModel GetById(Guid id)
    {
        return _repository.GetById(id);
    }
    
    public void Save(PostBlogDTO dto)
    {
        //Map 
        var blog = new BlogModel
        {
            Guid = Guid.NewGuid(),
            Title = dto.Title,
            author = new ShallowUser { Guid = dto.Author.Guid, Name = dto.Author.Name },
            posts = new List<ShallowPost>()
        };
        _repository.Save(blog);
    }
}