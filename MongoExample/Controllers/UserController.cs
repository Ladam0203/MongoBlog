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
    
    [HttpGet("{guid}")]
    public UserModel Get([FromRoute] string guid)
    {
        Guid id = Guid.Parse(guid);
        return _userService.GetById(id);
    }
    
    [HttpPost]
    public UserModel Post([FromBody] PostUserDTO user)
    {
        return _userService.Save(user);
    }
}