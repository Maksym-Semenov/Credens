using Credens.BLL.DTO;
using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Credens.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Credens.BLL.Implementations
{
    public class Service<T> : IService<T> where T : class
    {

        private readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<Dto<IEnumerable<T>>> MyGet()
        {
            var myDto = new Dto<IEnumerable<T>>();
            try
            {
                var myObj = await _repository.MySelect();

                if (myObj.Count() == 0)
                {
                    myDto.Description = "Object are not found";
                }
                myDto.Data = myObj;
            }
            catch(Exception ex)
            {
                new Dto<T>()
                {
                    Description = ex.Message
                };
            }
            return myDto;
            
        }

        public IQueryable<T> MyGetAll()
        {
            return _repository.GetAll();  
        }

        public void MyAdd(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Add(entity);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void MyAddRange(IEnumerable<T> entities)
        {
            try
            {
                if (entities != null )
                {
                    _repository.AddRange(entities);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


    }
}
