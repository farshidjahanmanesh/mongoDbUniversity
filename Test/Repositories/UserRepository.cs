using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_Learning.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Test;

namespace MongoDB_Learning.Repositories
{
    public interface IToDoRepository : IBaseRepository<ToDoList>
    {
        List<ToDoList> GetAllToDoLists();
        List<ToDo> GetAllTasks(ObjectId id);
        void InsertTask(ObjectId listId,ToDo todo);
        bool ChangeTaskStatus(ObjectId listid, int rowNumber);
    }
    public class ToDoRepository : IToDoRepository
    {
        private static string _collectionName = "ToDo";
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<ToDoList> _userCollection;
        public ToDoRepository(string dbName)
        {
            var client = new MongoClient();
            _db = client.GetDatabase(dbName);
            _userCollection = _db.GetCollection<ToDoList>(_collectionName);
        }
        public void Delete(ObjectId id)
        {
            if (id.Equals(null))
            {
                throw new System.Exception("id isnt valid");
            }
            _userCollection.DeleteOne(c => c.Id == id);
        }

        public void Delete(ToDoList entity)
        {
            if (entity.Equals(null))
            {
                throw new System.Exception("entity is null");
            }
            Delete(entity.Id);
        }

        public List<ToDoList> GetAllToDoLists()
        {
            return _userCollection.Find(new BsonDocument()).ToList();
        }

        public List<ToDo> GetAllTasks(ObjectId id)
        {
            var todo= _userCollection.Find(c => c.Id == id && c.UserId == HelperId.UserId.ToString()).First();
            return todo.ToDo; 
        }

        public ToDoList GetBy(ObjectId id)
        {
            if (id.Equals(null))
            {
                throw new System.Exception("id isnt valid");
            }
            return _userCollection.Find(c => c.Id == id).First();
        }

        public ToDoList GetBy(string name)
        {
            return _userCollection.Find(c => c.ToDolistText.ToLower() == name.ToLower()).First();
        }

        public ObjectId InsertTo(ToDoList entity)
        {
            var data = new ToDoList()
            {
                CompletedCount = 0,
                CreateTime = DateTime.Now,
                ToDolistText = entity.ToDolistText,
                UserId = HelperId.UserId.ToString()
            };
            _userCollection.InsertOne(data);
            return data.Id;
        }

        public void Update(ToDoList lastEntity, ToDoList newEntity)
        {
            throw new NotImplementedException();
        }

        public void InsertTask(ObjectId listId, ToDo todo)
        {
            var todoList = _userCollection.Find(c => c.Id == listId).First();
            var tasks = todoList.ToDo == null ? new List<ToDo>() : todoList.ToDo;
            tasks.Add(todo);
            todoList.ToDo = tasks;
            _userCollection.DeleteOne(c=>c.Id==listId);
            _userCollection.InsertOne(todoList);
           
        }

        public bool ChangeTaskStatus(ObjectId listId, int rowNumber)
        {
            var todoList = _userCollection.Find(c => c.Id == listId).First();
            var tasks = todoList.ToDo == null ? new List<ToDo>() : todoList.ToDo;
            if(tasks.Count>rowNumber)
            {
                tasks[rowNumber].Complete = !tasks[rowNumber].Complete;
                todoList.ToDo = tasks;
                _userCollection.DeleteOne(c => c.Id == listId);
                _userCollection.InsertOne(todoList);
                return tasks[rowNumber].Complete;
            }
            throw new Exception("rownumber is incorrect");
        }
    }
    public interface IUserRepository : IBaseRepository<User>
    {
        
    }
    public class UserRepository : IUserRepository
    {
        private static string _collectionName = "Users";
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<User> _userCollection;
        public UserRepository(string dbName)
        {
            var client = new MongoClient();
            _db = client.GetDatabase(dbName);
            _userCollection = _db.GetCollection<User>(_collectionName);
        }
        public void Delete(ObjectId id)
        {
            if (id.Equals(null))
            {
                throw new System.Exception("id isnt valid");
            }
            _userCollection.DeleteOne(c => c.Id == id);
        }

        public void Delete(User entity)
        {
            if (entity.Equals(null))
            {
                throw new System.Exception("entity is null");
            }
            this.Delete(entity.Id);
        }


        public User GetBy(ObjectId id)
        {
            return _userCollection.Find(c => c.Id == id).FirstOrDefault();
        }

        public User GetBy(string username)
        {
            return _userCollection.Find(c => c.UserName.ToLower() == username.ToLower()).FirstOrDefault();
        }

        public ObjectId InsertTo(User entity)
        {
            if (string.IsNullOrEmpty(entity.Name) ||
                string.IsNullOrEmpty(entity.LastName) ||
                string.IsNullOrEmpty(entity.UserName))
            {
                throw new Exception("fill input");
            }
            var isDuplicateUserName = _userCollection.Find(c => c.UserName == entity.UserName).Any();
            if (isDuplicateUserName)
                throw new Exception("duplicate user name");
            _userCollection.InsertOne(entity);
            return entity.Id;
        }

        public void Update(User lastEntity, User newEntity)
        {
            var filter = Builders<User>.Filter.Eq("_id", lastEntity.Id);
            var data = GetBy(lastEntity.Id);
            UpdateDefinitionBuilder<User> updateDef = Builders<User>.Update;
            var updates = new List<UpdateDefinition<User>>();
            foreach (var prop in typeof(User).GetProperties())
            {
                if (prop.GetValue(newEntity) != null)
                {
                    updates.Add(updateDef.Set(prop.Name, prop.GetValue(newEntity)));
                }
            }

            _userCollection.UpdateOne(filter, updateDef.Combine(updates));

        }
    }
}
