using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");

            var document = new BsonDocument
            {
                { "name", "MongoDB" },
                { "type", "Database" },
                { "count", 1 },
                { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }}
            };

            //collection.InsertOne(document);

            //var count = collection.Count(new BsonDocument());
            var filter = Builders<BsonDocument>.Filter.Eq("info.x", 203);
            var doc = collection.Find(filter).First();
            Console.WriteLine(doc);

            //var cursor = collection.Find(new BsonDocument()).ToCursor();
            //foreach (var doc in cursor.ToEnumerable())
            //{
            //    Console.WriteLine(doc);
            //}
        }
    }
}
