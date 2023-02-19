using Credens.BLL.DTO;
using Credens.BLL.Interface;
using Credens.DAL.Domain.Entities;
using Credens.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<Dto<IEnumerable<T>>> GetList()
        {
            var myDto = new Dto<IEnumerable<T>>();
            try
            {
                var myObj = await _repository.SelectAsync();

                if (myObj.Count() == 0)
                {
                    myDto.Description = "Object are not found";
                }
                myDto.Data = myObj;
                myDto.Description = "All right!";
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

      
        public Dto<IQueryable<T>> GetAll()
        {
            var myDto = new Dto<T>();
            try
            {
                var myObj = _repository.GetAll();
                if(myObj.Count() == 0)
                {
                    myDto.Description = "Object not faund";
                }
                myDto.Data = myObj as T;
            }
            catch(Exception ex)
            {
                new Dto<IQueryable<T>>() { };
            }
            return myDto as Dto<IQueryable<T>>;
        }

        public void Create(T entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Add(entity);
                    _repository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void AddRange(IEnumerable<T> entities)
        {
            try
            {
                if (entities != null )
                {
                    _repository.AddRange(entities);
                    _repository.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public Dto<T> Get(Expression<Func<T, bool>> predicate)
        {
            var myDto = new Dto<T>();
            try
            {
                var myObj = _repository.Get(predicate); 
                if (myObj != null)
                {
                    myDto.Description = "Object not faund";
                }
                myDto.Data = myObj;
            }
            catch (Exception ex) 
            {
                 new Dto<T>()
                { Description = ex.Message };
            }
            return myDto;
        }

        public async Task<Dto<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var myDto = new Dto<T>();
            try
            {
                var myObj = await _repository.GetAsync(predicate);
                if (myObj != null)
                {
                    myDto.Description = "Object not faund";
                }
                myDto.Data = myObj;
            }
            catch (Exception ex)
            {
                new Dto<T>()
                { 
                    Description = ex.Message
                };
            }
            return myDto;
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public void DeleteAll()
        {
           //_repository.RemoveRange(GetAll());
           _repository.SaveChanges();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _repository.SaveChanges();
        }

    }
}
