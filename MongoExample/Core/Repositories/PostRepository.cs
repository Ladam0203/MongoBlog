using System;
using System.Linq;
using MongoDB.Driver;
using MongoExample.Core.Models;
using MongoExample.Core.MongoClient;

namespace MongoExample.Core.Repositories;

public class PostRepository
{
    private readonly Client _client;
    private readonly string _databaseName;
    private readonly string _collectionName;

    public PostRepository(Client client,
        string databaseName = "mongoblog",
        string collectionName = "posts")
    {
        _client = client;
        _databaseName = databaseName;
        _collectionName = collectionName;
    }

    private IMongoCollection<PostModel> Here()
    {
        return _client.Collection<PostModel>(_databaseName, _collectionName);
    }

    public PostModel GetById(Guid id)
    {
        Console.WriteLine("Looking for post with id: " + id + " in the database.");
        PostModel post = Here().Find(x => x.Guid == id).FirstOrDefault();
        Console.WriteLine("Post: " + post.Title);
        return post;
    }

    public void Save(PostModel post)
    {
        Here().InsertOne(post);
    }

    public void Update(PostModel post)
    {
        Here().ReplaceOne(x => x.Guid == post.Guid, post);
    }

    public void Delete(Guid id)
    {
        Here().DeleteOne(x => x.Guid == id);
    }
}