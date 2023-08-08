using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
         where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                await context.Set<TEntity>().AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

        public TEntity AddT(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public TEntity Get(int Id)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Set<TEntity>().Find(Id);
                return entity;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public IEnumerable<TEntity> GetAll(bool tracking = true)
        {
            using (TContext context = new TContext())
            {
                var query = context.Set<TEntity>().AsQueryable();
                if (!tracking)
                    query = query.AsNoTracking();
                return query.ToList();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(bool tracking = true)
        {
            using (TContext context = new TContext())
            {
                var query = context.Set<TEntity>().AsQueryable();
                if (!tracking)
                    query = query.AsNoTracking();
                return await query.ToListAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, bool tracking = true)
        {
            using (TContext context = new TContext())
            {
                var query = context.Set<TEntity>().Where(predicate);
                if (!tracking)
                    query = query.AsNoTracking();
                return await query.ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            using (TContext context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public void Remove(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Remove(Expression<Func<TEntity, bool>> predicate)
        {
            RemoveRange(GetAll(predicate));
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().RemoveRange(entities);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity UpdateT(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
