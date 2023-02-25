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

        public async Task<DTO<IEnumerable<T>>> GetList()
        {
            var dto = new DTO<IEnumerable<T>>();
            try
            {
                var repObjects = await _repository.SelectAsync();

                if (repObjects.Count() == 0)
                {
                    dto.Description = "Object not found";
                    return dto;
                }
                dto.Data = repObjects;
                dto.Description = "Object is found";
            }
            catch(Exception ex)
            {
                new  DTO<IEnumerable<T>>()
                {
                    Description = ex.Message
                };
            }
            return dto;
        }

        public DTO<IQueryable<T>> GetAll()
        {
            var dto = new DTO<IQueryable<T>>();
            IQueryable<T> a = new IQueryable<T>();
            try
            {
                var repObjects = ;
                if(repObjects.Count() == 0)
                {
                    dto.Description = "Objects was not faund";
                }
                dto.Data = repObjects;
             
            }
            catch(Exception ex)
            {
                new DTO<IQueryable<T>>() {Description = ex.Message };
            }
            return dto;
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
                new DTO<T>() { Description = ex.Message };
            }
            
        }

        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                if (entity != null)
                {
                     await _repository.AddAsync(entity);
                     await _repository.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                new DTO<T>() { Description = ex.Message };
            }
            return true;
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

        public DTO<T> Get(Expression<Func<T, bool>> predicate)
        {
            var dto = new DTO<T>();
            try
            {
                var repObjects = _repository.Get(predicate); 
                if (repObjects != null)
                {
                    dto.Description = "Object not faund";
                }
                dto.Data = repObjects;
            }
            catch (Exception ex) 
            {
                 new DTO<T>()
                { Description = ex.Message };
            }
            return dto;
        }

        public async Task<DTO<T>> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var dto = new DTO<T>();
            try
            {
                var repObjects = await _repository.GetAsync(predicate);
                if (repObjects != null)
                {
                    dto.Description = "Object not faund";
                }
                dto.Data = repObjects;
            }
            catch (Exception ex)
            {
                new DTO<T>()
                { 
                    Description = ex.Message
                };
            }
            return dto;
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public void DeleteAll()
        {
           _repository.RemoveRange(_repository.Select());
           _repository.SaveChanges();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _repository.SaveChanges();
        }

    }
}
