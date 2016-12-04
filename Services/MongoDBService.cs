using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

using Mongo.NetCoreWebAPI.Models;

namespace Mongo.NetCoreWebAPI.Services
{
    public class MongoDBService
    {
        private IMongoCollection<TodoModel> TodoCollection { get; }
        public MongoDBService(string dbUrl, string dbName, string collectionName)
        {
            var mongoClient = new MongoClient(dbUrl);
            var mongoDB = mongoClient.GetDatabase(dbName);

            TodoCollection = mongoDB.GetCollection<TodoModel>(collectionName);
        }
        public async Task InsertTodo(TodoModel todo) => await TodoCollection.InsertOneAsync(todo);
        public async Task<List<TodoModel>> GetAllTodos() {
            var todos = new List<TodoModel>();
            var allDocument = await TodoCollection.FindAsync(new BsonDocument());
            await allDocument.ForEachAsync(doc => todos.Add(doc));
            return todos;
        }
    }
}