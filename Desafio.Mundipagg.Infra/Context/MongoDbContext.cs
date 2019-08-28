using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Desafio.Mundipagg.Infra.Context
{
    public class MongoDbContext<T> where T : class
    {            
        public IMongoCollection<T> collection { get; }
        
        public MongoDbContext(string nameCollection)
        {            
            var client = new MongoClient("mongodb://mongo:27017");
            var database = client.GetDatabase("desafio");

            collection = database.GetCollection<T>(nameCollection);
        }

        public List<T> Find()
        {            
            return collection.Find(new BsonDocument()).ToList();
        }

        public T FindById(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", new ObjectId(id));
            return collection.Find(filter).First();
        }

        public void Insert(T record)
        {            
            collection.InsertOne(record);
        }
        
        public void Update(T record, string id)
        {
            collection.ReplaceOne(new BsonDocument("_id", new ObjectId(id)), record, new UpdateOptions { IsUpsert = true });
        }

        public void Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq("Id", new ObjectId(id));
            collection.DeleteOne(filter);
        }
    }
}
