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
    
    public void Save(BlogModel blog)
    {
        _repository.Save(blog);
    }
}