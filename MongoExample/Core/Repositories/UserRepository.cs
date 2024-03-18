using MongoDB.Bson;
using MongoDB.Driver;
using MongoExample.Core.Models;
using MongoExample.Core.MongoClient;

namespace MongoExample.Core.Repositories;

public class UserRepository
{
    private readonly Client _client;
    private readonly string _databaseName;
    private readonly string _collectionName;
    
    public UserRepository(Client client, 
        string databaseName = "mongoblog", 
        string collectionName = "users")
    {
        _client = client;
        _databaseName = databaseName;
        _collectionName = collectionName;
    }
    
    private IMongoCollection<UserModel> Here()
    {
        return _client.Collection<UserModel>(_databaseName, _collectionName);
    }

    public UserModel GetById(Guid id)
    {
        return Here().Find(x => x.Guid == id).FirstOrDefault();
    }

    public void Save(UserModel user)
    {
        Here().InsertOne(user);
    }
    
    public void Update(UserModel user)
    {
        Here().ReplaceOne(x => x.Guid == user.Guid, user);
    }
    
    public void Delete(Guid id)
    {
        Here().DeleteOne(x => x.Guid == id);
    }
}