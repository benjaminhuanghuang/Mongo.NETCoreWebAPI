using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.NetCoreWebAPI.Models
{
    public class TodoModel
    {
        [BsonId]
        public ObjectId TodoId { get; set; }

        [BsonRequired]
        public string Title { get; set; }

        public bool Completed { get; set; } = false;
        public DateTime? OpTime { get; set; } = null;
    }
}