using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.DTO
{
    public class Dto<T>
    {
        public string Description { get; set; }
        public T Data { get; set; }
     
    }
}
