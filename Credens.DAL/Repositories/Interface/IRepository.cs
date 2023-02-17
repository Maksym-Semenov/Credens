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
        /// <summary>
        /// Persists all updates to the data source
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Persists all updates to the data source async
        /// </summary>
        Task SaveChangesAsync();

        /// <summary>
        /// Get first entity by predicate 
        /// </summary>
        /// <param name="predicate">LINQ predicate</param>
        /// <returns>T entity</returns>
        T First(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get first entity by predicate 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>T entity</returns>
        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get first entity
        /// </summary>
        /// <returns>T entity</returns>
        T FirstOrDefault();

        /// <summary>
        /// Get first entity async
        /// </summary>
        /// <returns>T entity</returns>
        Task<T> FirstOrDefaultAsync();

        /// <summary>
        /// Get all queries
        /// </summary>
        /// <returns>IQueryable queries</returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Find queries by predicate (where logic)
        /// </summary>
        /// <param name="predicate">Search predicate (LINQ)</param>
        /// <returns>IQueryable queries</returns>
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Find queries by predicate
        /// </summary>
        /// <param name="predicate">Search predicate (LINQ)</param>
        /// <returns>IQueryable queries</returns>
        bool Any(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Find entity by keys
        /// </summary>
        /// <param name="keys">Search key</param>
        /// <returns>T entity</returns>
        T Find(params object[] keys);

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <param name="entity">Entity object</param>
        void Add(T entity);

        /// <summary>
        /// Add new entities
        /// </summary>
        /// <param name="entities">Entity collection</param>
        void AddRange(IEnumerable<T> entities);

        /// <summary>
        /// Remove entity from database
        /// </summary>
        /// <param name="entity">Entity object</param>
        void Delete(T entity);

        /// <summary>
        /// Remove entities from database
        /// </summary>
        /// <param name="entity">Entity object</param>
        void DeleteRange(IEnumerable<T> entity);

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="entity">Entity object</param>
        void Update(T entity);

        /// <summary>
        /// Order by
        /// </summary>
        IOrderedQueryable<T> OrderBy<K>(Expression<Func<T, K>> predicate);

        /// <summary>
        /// Order by
        /// </summary>
        IQueryable<IGrouping<K, T>> GroupBy<K>(Expression<Func<T, K>> predicate);

        /// <summary>
        /// Remove range of given entities
        /// </summary>
        void RemoveRange(IEnumerable<T> entities);
    }
}
