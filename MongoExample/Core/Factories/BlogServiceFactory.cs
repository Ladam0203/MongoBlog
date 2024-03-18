using Microsoft.AspNetCore.Http.HttpResults;
using MongoExample.Core.MongoClient;
using MongoExample.Core.Repositories;
using MongoExample.Core.Services;

namespace MongoExample.Core.Factories;

public static class BlogServiceFactory
{
    public static BlogService Create()
    {
        var client = new Client("mongodb://localhost:27017"); //TODO: Move to config
        var repository = new BlogRepository(client);
        return new BlogService(repository);
    }
}