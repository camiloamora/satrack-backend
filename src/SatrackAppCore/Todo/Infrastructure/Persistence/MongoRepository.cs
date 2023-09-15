using MongoDB.Bson;
using MongoDB.Driver;
using SatrackAppCore.Todo.Domain;
using SatrackAppCore.Todo.Infrastructure.Dto;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System;

namespace SatrackAppCore.Todo.Infrastructure.Persistence;

public class MongoRepository : ITodoRepository
{
    private readonly IMongoCollection<TodoItem> collection;

    public MongoRepository(IMongoDatabaseSettings settings)
    {
        var client = new MongoClient(settings.DatabaseConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        collection = database.GetCollection<TodoItem>(settings.CollectionName);
    }

    public async Task Save(TodoItem todo)
    {
        await collection.InsertOneAsync(todo);
    }

    public async Task<ICollection<TodoItem>> SearchAll()
    {
        return await collection.Find(s => true).ToListAsync();
    }

    public async Task UpdateById(Guid id)
    {
        if (id == null)
        {
            throw new ArgumentNullException(nameof(id));
        }

        var filters = Builders<TodoItem>.Filter.Eq("_id", id);
        var update = Builders<TodoItem>.Update.Set("Status", Status.Completada);
        await collection.UpdateOneAsync(filters, update);
    }

    public async Task DeleteById(Guid id)
    {
         if (id == null)
        {
            throw new ArgumentNullException(nameof(id));
        }
        
        var filters = Builders<TodoItem>.Filter.Eq("_id", id);
        await collection.DeleteOneAsync(filters);
    }
}