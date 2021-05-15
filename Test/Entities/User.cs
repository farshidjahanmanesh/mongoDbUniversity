using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text;

namespace MongoDB_Learning.Entities
{
    public class User
    {   
        [BsonId]
        public ObjectId Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }

    }
}
