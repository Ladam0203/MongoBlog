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

    public UserModel GetById(string uuid)
    {
        return Here().Find(x => x.Uuid == uuid).FirstOrDefault();
    }

    public void Save(UserModel user)
    {
        Here().InsertOne(user);
    }
    
    public void Update(UserModel user)
    {
        Here().ReplaceOne(x => x.Uuid == user.Uuid, user);
    }
    
    public void Delete(string uuid)
    {
        Here().DeleteOne(x => x.Uuid == uuid);
    }
}