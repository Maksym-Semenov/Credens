using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using System.Linq.Expressions;

namespace Credens.BLL.Implementations
{
    public class ProjectService : IService<ProjectDTO>
    {
        private readonly IRepository<ProjectDTO> _repository;

        public ProjectService(IRepository<ProjectDTO> repository)
        {
            _repository = repository;
        }

        public IQueryable<ProjectDTO> GetAll()
        {
            return _repository.GetAll();
        }

        public void Create(ProjectDTO entity)
        {
            _repository.Add(entity);
            _repository.SaveChanges();
        }

        public async Task CreateAsync(ProjectDTO entity)
        {
            await _repository.AddAsync(entity);
            _repository.SaveChangesAsync();
        }

        public void Update(ProjectDTO entity)
        {
            _repository.Update(entity);
        }

        public async Task<IEnumerable<ProjectDTO>> GetListAsync()
        {
            return await _repository.GetListAsync();
        }

        public void Delete(ProjectDTO entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public async Task<ProjectDTO> GetAsync(Expression<Func<ProjectDTO, bool>> predicate)
        {
            return await _repository.GetAsync(predicate);
        }

        public ProjectDTO Get(Expression<Func<ProjectDTO, bool>> predicate)
        {
            return _repository.Get(predicate);
        }



    //    public async Task<ProjectDTO<IEnumerable<T>>> GetList()
    //    {
    //        var dto = new ProjectDTO<IEnumerable<T>>();
    //        try
    //        {
    //            var repObjects = await _repository.SelectAsync();

    //            if (repObjects.Count() == 0)
    //            {
    //                dto.Description = "Object not found";
    //                return dto;
    //            }
    //            dto.Data = repObjects;
    //            dto.Description = "Object is found";
    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<IEnumerable<T>>()
    //            {
    //                Description = ex.Message
    //            };
    //        }
    //        return dto;
    //    }

    //    public ProjectDTO<IQueryable<T>> GetAll()
    //    {
    //        var dto = new ProjectDTO<IQueryable<T>>();
    //        IQueryable<T> a = new IQueryable<T>();
    //        try
    //        {
    //            var repObjects = ;
    //            if (repObjects.Count() == 0)
    //            {
    //                dto.Description = "Objects was not faund";
    //            }
    //            dto.Data = repObjects;

    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<IQueryable<T>>() { Description = ex.Message };
    //        }
    //        return dto;
    //    }

    //    public void Create(T entity)
    //    {
    //        try
    //        {
    //            if (entity != null)
    //            {
    //                _repository.Add(entity);
    //                _repository.SaveChanges();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<T>() { Description = ex.Message };
    //        }

    //    }

    //    public async Task<bool> CreateAsync(T entity)
    //    {
    //        try
    //        {
    //            if (entity != null)
    //            {
    //                await _repository.AddAsync(entity);
    //                await _repository.SaveChangesAsync();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<T>() { Description = ex.Message };
    //        }
    //        return true;
    //    }

    //    public void AddRange(IEnumerable<T> entities)
    //    {
    //        try
    //        {
    //            if (entities != null)
    //            {
    //                _repository.AddRange(entities);
    //                _repository.SaveChanges();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception();
    //        }
    //    }

    //    public ProjectDTO<T> Get(Expression<Func<T, bool>> predicate)
    //    {
    //        var dto = new ProjectDTO<T>();
    //        try
    //        {
    //            var repObjects = _repository.Get(predicate);
    //            if (repObjects != null)
    //            {
    //                dto.Description = "Object not faund";
    //            }
    //            dto.Data = repObjects;
    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<T>()
    //            { Description = ex.Message };
    //        }
    //        return dto;
    //    }

    //    public async Task<ProjectDTO<T>> GetAsync(Expression<Func<T, bool>> predicate)
    //    {
    //        var dto = new ProjectDTO<T>();
    //        try
    //        {
    //            var repObjects = await _repository.GetAsync(predicate);
    //            if (repObjects != null)
    //            {
    //                dto.Description = "Object not faund";
    //            }
    //            dto.Data = repObjects;
    //        }
    //        catch (Exception ex)
    //        {
    //            new ProjectDTO<T>()
    //            {
    //                Description = ex.Message
    //            };
    //        }
    //        return dto;
    //    }

    //    public void Delete(T entity)
    //    {
    //        _repository.Delete(entity);
    //        _repository.SaveChanges();
    //    }

    //    public void DeleteAll()
    //    {
    //        _repository.RemoveRange(_repository.Select());
    //        _repository.SaveChanges();
    //    }

    //    public void Update(T entity)
    //    {
    //        _repository.Update(entity);
    //        _repository.SaveChanges();
    //    }

    //}
}
}