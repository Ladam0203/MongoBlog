﻿using MongoExample.Core.MongoClient;
using MongoExample.Core.Repositories;
using MongoExample.Core.Services;

namespace MongoExample.Core.Factories;

public class PostServiceFactory
{
    public static PostService Create()
    {
        var client = new Client("mongodb://localhost:27017"); //TODO: Move to config
        var repository = new PostRepository(client);
        return new PostService(repository);
    }
}