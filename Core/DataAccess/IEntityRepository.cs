using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<T> AddAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetAsync(int id);
        T Get(int Id);
        Task<IEnumerable<T>> GetAllAsync(bool tracking = true);
        T UpdateT(T entity);
        IEnumerable<T> GetAll(bool tracking = true);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, bool tracking = true);
        T AddT(T entity);
        void RemoveRange(IEnumerable<T> entities);
        void Remove(T entity);
        void Remove(Expression<Func<T, bool>> predicate);

    }
}
