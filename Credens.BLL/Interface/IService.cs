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

        public Dto<IQueryable<T>> GetAll();

        public Task<Dto<IEnumerable<T>>> GetList();

        public Task<Dto<T>> GetAsync(Expression<Func<T, bool>> predicate);

        public Dto<T> Get(Expression<Func<T, bool>> predicate);

        public void Delete(T entity);

        public void DeleteAll();

        public void Update(T entity);
    }
}
