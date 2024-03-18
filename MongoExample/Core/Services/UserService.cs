using MongoExample.Core.Models;
using MongoExample.Core.Repositories;

namespace MongoExample.Core.Services;

public class UserService
{
    private readonly UserRepository _userRepository;
    
    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public UserModel GetById(Guid id)
    {
        return _userRepository.GetById(id);
    }
    
    public void Save(UserModel user)
    {
        _userRepository.Save(user);
    }
    
    public void Delete(Guid id)
    {
        _userRepository.Delete(id);
    }
    
    public void Update(UserModel user)
    {
        _userRepository.Update(user);
    }
}