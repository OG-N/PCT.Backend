﻿using Microsoft.EntityFrameworkCore;
using PCT.Backend.Entities;
using System.Linq.Expressions;

namespace PCT.Backend.Repository
{
    public class Repository<T> where T : Entity
    {
        protected readonly DataContext _dataContext;
        private readonly DbSet<T> DbSet;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
            DbSet = _dataContext.Set<T>();
        }

        public T Create(T entity)
        {
            DbSet.Add(entity);
            _dataContext.SaveChanges();
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public T Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dataContext.Entry(entity).State = EntityState.Modified;
            _dataContext.SaveChanges();
            return entity;
        }

        public List<T> ExecuteSQL<T>(FormattableString query) where T : class
        {
            var result = _dataContext.Database
                                .SqlQuery<T>(query)
                                .ToList();

            return result;
        }

        public T GetById(Guid id)
        {
            return DbSet.SingleOrDefault(x => x.Id == id);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dataContext.Dispose();
            }
        }
    }
}
