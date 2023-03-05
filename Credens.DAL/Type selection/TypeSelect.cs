using Credens.DAL.Domain.Entities;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credens.DAL.Type_selection
{
    public class TypeSelect<T> where T : class, new()
    {
        public static Type TypeSelection(T myDTO)
        {
            switch (myDTO.GetType().ToString())
            {
                case "ProjectDTO":
                    return  typeof(Project);
                case "Branch":
                    return typeof(Branch);
                case "Contact":
                    return typeof(Contact);
                case "User":
                    return typeof(User);
                default: throw new NotImplementedException();
            }
        }
    }
}
