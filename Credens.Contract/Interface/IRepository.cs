using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Repositories.Interface
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> Select();

        public Task<List<T>> SelectAsync();

        public T Get(Expression<Func<T,bool>> predicate);

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        void SaveChanges();

        Task SaveChangesAsync();
 
        T First(Expression<Func<T, bool>> predicate);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        T FirstOrDefault();

        Task<T> FirstOrDefaultAsync();

        IQueryable<T> GetAll();

        bool Any(Expression<Func<T, bool>> predicate);

        T Find(params object[] keys);

        Task<T> FindAsync(params object[] keys);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);
        
        Task<bool> AddAsync(T entity);

        void AddRangeAsync(IEnumerable<T> entities);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entity);

        void Update(T entity);

        IOrderedQueryable<T> OrderBy<K>(Expression<Func<T, K>> predicate);

        IQueryable<IGrouping<K, T>> GroupBy<K>(Expression<Func<T, K>> predicate);

        void RemoveRange(IEnumerable<T> entities);
        void Remove(T entitie);
    }
}
