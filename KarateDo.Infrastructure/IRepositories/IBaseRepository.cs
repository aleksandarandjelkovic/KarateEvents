using KarateDo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace KarateDo.Infrastructure.IRepositories
{
    public interface IBaseRepository
    {
        //GetById
        T GetById<T>(int id, params string[] includeProperties) where T : BaseEntity;
        T GetById<T>(int id) where T : class;

        //GetAll
        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> GetAll<T>(params string[] includeProperties) where T : class;
        IQueryable<T> GetAll<T>(IEnumerable<int> ids) where T : BaseEntity;
        IQueryable<T> GetAll<T>(IEnumerable<int> ids, params string[] includeProperties) where T : BaseEntity;
        IQueryable<T> GetAll<T>(Expression<Func<T, bool>> query) where T : class;
        IQueryable<T> GetAll<T>(Expression<Func<T, bool>> wherePredicate, params string[] includeProperties) where T : class;

        //GetByExpression
        T GetByExpression<T>(Expression<Func<T, bool>> wherePredicate, params string[] includeProperties) where T : class;

        void Delete<T>(int id) where T : class;
        void Add<T>(T entity) where T : class;
        void SaveOrUpdate<T>(T entity, bool commit = true) where T : BaseEntity;

        void Dispose(bool disposing);
    }
}
