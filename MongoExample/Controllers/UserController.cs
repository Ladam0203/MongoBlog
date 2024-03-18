using Microsoft.AspNetCore.Mvc;
using MongoExample.Core.Models;
using MongoExample.Core.Services;

namespace MongoExample.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly UserService _userService;
    
    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public UserModel Get(string uuid)
    {
        return _userService.GetById(uuid);
    }
    
    [HttpPost]
    public void Post([FromBody] UserModel user)
    {
        _userService.Save(user);
    }
}