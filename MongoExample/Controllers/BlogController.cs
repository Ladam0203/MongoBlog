using Microsoft.AspNetCore.Mvc;
using MongoExample.Core.Models;
using MongoExample.Core.Services;

namespace MongoExample.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogController
{
    private readonly BlogService _service;
    
    public BlogController(BlogService service)
    {
        _service = service;
    }
    
    [HttpGet("{guid}")]
    public BlogModel Get(Guid id)
    {
        return _service.GetById(id);
    }
    
    [HttpPost]
    public void Post([FromBody] PostBlogDTO dto)
    {
        _service.Save(dto);
    }
}