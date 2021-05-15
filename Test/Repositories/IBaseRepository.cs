using MongoDB.Bson;
using MongoDB_Learning.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB_Learning.Repositories
{
    public interface IBaseRepository<T>
    {
        T GetBy(ObjectId id);
        T GetBy(string name);
        ObjectId InsertTo(T entity);
        void Delete(ObjectId id);
        void Delete(T entity);
        void Update(T lastEntity, T newEntity);
    }

   
}
