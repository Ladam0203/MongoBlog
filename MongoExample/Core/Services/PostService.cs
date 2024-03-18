using System;
using MongoExample.Core.Models;
using MongoExample.Core.Repositories;

namespace MongoExample.Core.Services;

public class PostService
{
    private readonly PostRepository _repository;

    public PostService(PostRepository repository)
    {
        _repository = repository;
    }

    public PostModel GetById(Guid id)
    {
        return _repository.GetById(id);
    }

    public PostModel Save(PostPostDTO dto)
    {
        var post = new PostModel
        {
            Guid = Guid.NewGuid(),
            Title = dto.Title,
            Content = dto.Content,
            Timestamp = DateTime.Now,
            blog = dto.Blog,
            author = dto.Author
        };
        _repository.Save(post);
        return post;
    }
}