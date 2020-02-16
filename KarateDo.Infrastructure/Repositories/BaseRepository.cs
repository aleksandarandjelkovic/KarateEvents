using KarateDo.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using KarateDo.Domain.Entities;

namespace KarateDo.Infrastructure.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public ApplicationDbContext dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException("dbContext");
        }

        private object DbSet { get; set; }

        protected DbSet<T> GetDbSet<T>() where T : class
        {
            if (!(DbSet is DbSet<T> dbs))
            {
                DbSet = (DbSet<T>)dbContext.Set<T>();
            }

            return (DbSet<T>)DbSet;
        }

        public T GetById<T>(int id, params string[] includeProperties) where T : BaseEntity
        {
            return includeProperties != null ? GetByExpression<T>(x => x.Id == id, includeProperties) : GetById<T>(id);
        }

        public T GetById<T>(int id) where T : class
        {
            return GetDbSet<T>().Find(id);
        }

        public T GetByExpression<T>(Expression<Func<T, bool>> wherePredicate, params string[] includeProperties) where T : class
        {
            var query = GetDbSet<T>().AsQueryable();

            if (includeProperties != null && includeProperties.Count() > 0)
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }

            return query.SingleOrDefault(wherePredicate);
        }

        public void SaveOrUpdate<T>(T entity, bool commit = true) where T : BaseEntity
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (entity.Id != 0)
            {
                if (dbEntityEntry.State == EntityState.Detached)
                {
                    GetDbSet<T>().Attach(entity);
                }
                dbEntityEntry.State = EntityState.Modified;
            }
            else
            {
                if (dbEntityEntry.State != EntityState.Detached)
                {
                    dbEntityEntry.State = EntityState.Added;
                }
                else
                {
                    GetDbSet<T>().Add(entity);
                }
            }

            if (commit)
            {
                dbContext.SaveChanges();
            }
        }

        public void Add<T>(T entity) where T : class
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                GetDbSet<T>().Add(entity);
            }

            dbContext.SaveChanges();
        }

        public void Delete<T>(int id) where T : class
        {
            var entity = GetById<T>(id);
            if (entity == null) return;
            Delete(entity);

            dbContext.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            DbEntityEntry dbEntityEntry = dbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                GetDbSet<T>().Attach(entity);
                GetDbSet<T>().Remove(entity);
            }
            dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return GetDbSet<T>();
        }

        public IQueryable<T> GetAll<T>(params string[] includeProperties) where T : class
        {
            var query = GetAll<T>();

            if (includeProperties != null && includeProperties.Count() > 0)
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }

            return query;
        }

        public IQueryable<T> GetAll<T>(IEnumerable<int> ids) where T : BaseEntity
        {
            return GetDbSet<T>().Where(t => ids.Contains(t.Id));
        }

        public IQueryable<T> GetAll<T>(IEnumerable<int> ids, params string[] includeProperties) where T : BaseEntity
        {
            var query = GetDbSet<T>().Where(t => ids.Contains(t.Id));

            if (includeProperties != null && includeProperties.Count() > 0)
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }

            return query;
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> query) where T : class
        {
            return GetDbSet<T>().Where(query);
        }

        public IQueryable<T> GetAll<T>(Expression<Func<T, bool>> wherePredicate, params string[] includeProperties) where T : class
        {
            var query = GetAll<T>();

            if (includeProperties != null && includeProperties.Count() > 0)
            {
                foreach (var property in includeProperties)
                {
                    query = query.Include(property);
                }
            }

            return query.Where(wherePredicate);
        }

        public void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
    }
}
