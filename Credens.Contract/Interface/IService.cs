using Credens.Infrastructure.DTO;
using System.Linq.Expressions;

namespace Credens.Infrastructure.Interface
{
    public interface IService<T> where T : class
    {
        public void Create(T entity);
        
        public Task CreateAsync(T entity);

        public IQueryable<ProjectDTO> GetAll();

        public Task<IEnumerable<ProjectDTO>> GetListAsync();

        public Task<ProjectDTO> GetAsync(Expression<Func<T, bool>> predicate);

        public ProjectDTO Get(Expression<Func<T, bool>> predicate);

        public void Delete(T entity);

        public void Update(T entity);

    }
}
