using System.Linq.Expressions;

namespace Credens.Infrastructure.Interface
{
    public interface IRepository<T>   where T : class, new()
    {
        public Task<IEnumerable<T>> GetListAsync();
        
        public IQueryable<T> GetAll();

        public T Get(Expression<Func<T, bool>> predicate);

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        void SaveChanges();

        Task SaveChangesAsync();

        void Add(T entity);
        
        Task AddAsync(T entity);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entity);

        void Update(T entity);

    }
}
