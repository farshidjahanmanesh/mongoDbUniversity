using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoDB_Learning.Entities
{
    public class ToDoList
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int CompletedCount { get; set; }
        public string ToDolistText { get; set; }

        public string UserId { get; set; }
        public List<ToDo> ToDo { get; set; }
    }





}
