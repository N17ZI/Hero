using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Hero
{
    internal class User
    {
        public User(string name, string hero, double strength, double dexterity, double constitution, double intellicence)
        {
            Name = name;
            Hero = hero;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intellicence = intellicence;
            Items = new List<Item>();
        }
        [BsonId]
        ObjectId _id;
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonIgnoreIfNull]
        [BsonElement("Hero")]
        public string Hero { get; set; }
        [BsonIgnoreIfNull]
        public double Strength { get; set; }
        [BsonIgnoreIfNull]
        public double Dexterity { get; set; }
        [BsonIgnoreIfNull]
        public double Constitution { get; set; }
        [BsonIgnoreIfNull]
        public double Intellicence { get; set; }
        [BsonIgnoreIfNull]
        List<Item> Items { get; set; }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
