using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        T Insert(T t);
        T Update(T t);
        int Delete(T t);

        IEnumerable<T> Query(Func<IQueryable<T>, IEnumerable<T>> query);
    }
}
