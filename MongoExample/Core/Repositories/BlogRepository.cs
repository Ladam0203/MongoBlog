using MongoDB.Driver;
using MongoExample.Core.Models;
using MongoExample.Core.MongoClient;

namespace MongoExample.Core.Repositories;

public class BlogRepository
{
    private readonly Client _client;
    private readonly string _databaseName;
    private readonly string _collectionName;
    
    public BlogRepository(Client client, 
        string databaseName = "mongoblog", 
        string collectionName = "blogs")
    {
        _client = client;
        _databaseName = databaseName;
        _collectionName = collectionName;
    }
    
    private IMongoCollection<BlogModel> Here()
    {
        return _client.Collection<BlogModel>(_databaseName, _collectionName);
    }
    
    public BlogModel GetById(Guid id)
    {
        return Here().Find(x => x.Guid == id).FirstOrDefault();
    }

    public void Save(BlogModel blog)
    {
        Here().InsertOne(blog);
    }
}