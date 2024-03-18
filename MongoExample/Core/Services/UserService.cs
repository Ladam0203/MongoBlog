using MongoExample.Core.Models;
using MongoExample.Core.Repositories;

namespace MongoExample.Core.Services;

public class UserService
{
    private readonly UserRepository _repository;
    
    public UserService(UserRepository repository)
    {
        _repository = repository;
    }
    
    public UserModel GetById(Guid id)
    {
        return _repository.GetById(id);
    }
    
    public void Save(PostUserDTO dto)
    {
        // Map
        var user = new UserModel
        {
            Guid = Guid.NewGuid(),
            Name = dto.Name,
            blogs = new List<ShallowBlog>()
        };
        _repository.Save(user);
    }
    
    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }
    
    public void Update(UserModel user)
    {
        _repository.Update(user);
    }
}