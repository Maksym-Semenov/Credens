using Credens.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.Interface
{
    public interface IService<T> where T : class
    {
        public void Create(T entity);
        
        public Task<bool> CreateAsync(T entity);

        public void AddRange(IEnumerable<T> entities);

        public DTO<IQueryable<T>> GetAll();

        public Task<DTO<IEnumerable<T>>> GetList();

        public Task<DTO<T>> GetAsync(Expression<Func<T, bool>> predicate);

        public DTO<T> Get(Expression<Func<T, bool>> predicate);

        public void Delete(T entity);

        public void DeleteAll();

        public void Update(T entity);

    }
}
