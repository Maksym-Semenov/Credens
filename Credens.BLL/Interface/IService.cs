using Credens.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.Interface
{
    public interface IService<T> where T : class
    {
        public void MyAdd(T entity);
        public void MyAddRange(IEnumerable<T> entities);
        public IQueryable<T> MyGetAll();
        public Task<Dto<IEnumerable<T>>> MyGet();

    }
}
