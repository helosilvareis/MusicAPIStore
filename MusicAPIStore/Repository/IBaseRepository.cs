using System;
using System.Linq;
using System.Linq.Expressions;

namespace MusicAPIStore.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        //IQueryable<T> GetAll();
        //IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        bool Validate(T entity);
        void Add(T entity);
        //void Delete(T entity);
        //void Edit(T entity);
        //void Save();
    }
}