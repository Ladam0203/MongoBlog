using Microsoft.AspNetCore.Mvc;
using MongoExample.Core.Models;
using MongoExample.Core.Services;

namespace MongoExample.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly PostService _postService;

    public PostController(PostService postService)
    {
        _postService = postService;
    }

    [HttpGet("{guid}")]
    public PostModel Get([FromRoute] string guid)
    {
        Guid id = Guid.Parse(guid);
        return _postService.GetById(id);
    }

    [HttpPost]
    public PostModel Post([FromBody] PostPostDTO dto)
    {
        return _postService.Save(dto);
    }
}