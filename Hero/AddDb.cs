using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
namespace Hero
{
    internal class AddDb
    {
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }
        public static void FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" {item?.Name}");
            }
        }
        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();
            Console.WriteLine($" {one?.Name}");
        }
        public static void ReplaceByName(string name, User user1)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("Examples321");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == name, user1);
        }
    }
}
