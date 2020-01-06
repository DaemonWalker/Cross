using Cross.DBContexts;
using Cross.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly BaseDbContext _dbContext;
        protected virtual DbSet<T> GetDbSet()
        {
            return _dbContext.GetDbSet<T>();
        }
        public BaseRepository(BaseDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public int Delete(T t)
        {
            var dbSet = this.GetDbSet();
            dbSet.Remove(t);
            return _dbContext.SaveChanges();
        }

        public T Insert(T t)
        {
            var dbSet = this.GetDbSet();
            t = dbSet.Add(t).Entity;
            _dbContext.SaveChanges();
            return t;
        }

        public IEnumerable<T> Query(Func<IQueryable<T>, IEnumerable<T>> query)
        {
            var dbSet = this.GetDbSet();
            return query(dbSet);
        }

        public T Update(T t)
        {
            var dbSet = this.GetDbSet();
            t = dbSet.Update(t).Entity;
            _dbContext.SaveChanges();
            return t;
        }
    }
}
