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
    
    public UserModel GetById(string uuid)
    {
        return _userRepository.GetById(uuid);
    }
    
    public void Save(UserModel user)
    {
        _userRepository.Save(user);
    }
    
    public void Delete(string uuid)
    {
        _userRepository.Delete(uuid);
    }
    
    public void Update(UserModel user)
    {
        _userRepository.Update(user);
    }
}