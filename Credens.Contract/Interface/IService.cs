using Credens.Infrastructure.DTO;
using System.Linq.Expressions;

namespace Credens.Infrastructure.Interface
{
    public interface IService<T> where T : class
    {
        //public void Create(T entity);
        
        //public Task<bool> CreateAsync(T entity);

        //public void AddRange(IEnumerable<T> entities);

        public IQueryable<ProjectDTO> GetAll();

        public Task<IEnumerable<ProjectDTO>> GetListAsync();

        public T GetById (int id);

        //public Task<ProjectDTO> GetAsync(Expression<Func<T, bool>> predicate);

        //public ProjectDTO Get(Expression<Func<T, bool>> predicate);

        //public void Delete(T entity);

        //public void DeleteAll();

        //public void Update(T entity);

    }
}
