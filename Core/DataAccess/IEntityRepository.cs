using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //generic constraint
    // class: references tip olmalı demek,
    //IEntity olabilir yada implement edileni olabilir
    //new ile IEntity olmamasını sağladım
    public interface IEntityRepository<T> where T:class , IEntity, new()
    {
        //CRUD operasyonları yazıldı
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
