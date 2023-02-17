using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.Interface
{
    public interface IService<T> where T : class
    {
        public void Add1(T entity);
        public void AddRange(IEnumerable<T> entities);

    }
}
