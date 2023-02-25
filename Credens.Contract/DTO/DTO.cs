using Credens.DAL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.DTO
{
    public class DTO<T>
    {
        public string Description { get; set; }

        public T Data { get; set; }
    }

   
}
