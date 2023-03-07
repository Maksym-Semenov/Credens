using Credens.Infrastructure.DTO;
using System.Linq.Expressions;

namespace Credens.Infrastructure.Interface
{
    public interface IService<T> where T : class
    {
        public void Create(T entity);
        
        public Task CreateAsync(T entity);

        public IQueryable<T> GetAll();

        public Task<IEnumerable<T>> GetListAsync();

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        public T Get(Expression<Func<T, bool>> predicate);

        public void Delete(T entity);

        public void Update(T entity);

    }
}
