
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Credens.DAL.AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Credens.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly IMapper _mapper;
        private readonly IMapper _mapper2;
        private readonly CredensDbContext _context;

        public Repository(CredensDbContext context)
        {
            _context = context;

            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        _mapper = CredensMapper<Project, T>.MapperInit();
                        _mapper2 = CredensMapper<T, Project>.MapperInit();
                        break;
                    }
                case "UserDTO":
                    {
                        _mapper = CredensMapper<User, T>.MapperInit();
                        _mapper2 = CredensMapper<T, User>.MapperInit();
                        break;
                    }
                case "BranchDTO":
                    {
                        _mapper = CredensMapper<Branch, T>.MapperInit();
                        _mapper2 = CredensMapper<T, Branch>.MapperInit();
                        break;
                    }
                case "ContactDTO":
                    {
                        _mapper = CredensMapper<Contact, T>.MapperInit();
                        _mapper2 = CredensMapper<T, Contact>.MapperInit();
                        break;
                    }
                    default: { throw new NotImplementedException(); }
            }
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
          switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
                    }
                case "UserDTO": 
                    {
                        var _dbSet = _context.Set<User>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
                    }
                default: { throw new NotImplementedException(); }
            }
        }

        public IQueryable<T> GetAll()
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider);
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider);
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider);
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        return _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider);
                    }
                default: { throw new NotImplementedException(); }
            }
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        return await _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        return await _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        return await _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        return await _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                default: { throw new NotImplementedException(); }
            }
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        return _mapper.Map<IEnumerable<T>>(await _dbSet.ToListAsync());
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        return _mapper.Map<IEnumerable<T>>(await _dbSet.ToListAsync());
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        return _mapper.Map<IEnumerable<T>>(await _dbSet.ToListAsync());
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        return _mapper.Map<IEnumerable<T>>(await _dbSet.ToListAsync());
                    }
                default: { throw new NotImplementedException(); }
            }
            
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }

        public void Add(T entity)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        _dbSet.Add(_mapper2.Map<Project>(entity));
                        break;
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        _dbSet.Add(_mapper2.Map<User>(entity));
                        break;
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        _dbSet.Add(_mapper2.Map<Branch>(entity));
                        break;
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        _dbSet.Add(_mapper2.Map<Contact>(entity));
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }
          
        }

        public async Task AddAsync(T entity)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        await _dbSet.AddAsync(_mapper2.Map<Project>(entity));
                        break;
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        await _dbSet.AddAsync(_mapper2.Map<User>(entity));
                        break;
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        await _dbSet.AddAsync(_mapper2.Map<Branch>(entity));
                        break;
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        await _dbSet.AddAsync(_mapper2.Map<Contact>(entity));
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }
        }
        
        public void Delete(T entity)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        _dbSet.Remove(_mapper2.Map<Project>(entity));
                        break;
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        _dbSet.Remove(_mapper2.Map<User>(entity));
                        break;
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        _dbSet.Remove(_mapper2.Map<Branch>(entity));
                        break;
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        _dbSet.Remove(_mapper2.Map<Contact>(entity));
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }
           
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        var entitys = _mapper2.Map<IEnumerable<Project>>(entity);
                        _dbSet.RemoveRange(entitys);
                        break;
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        var entitys = _mapper2.Map<IEnumerable<User>>(entity);
                        _dbSet.RemoveRange(entitys);
                        break;
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        var entitys = _mapper2.Map<IEnumerable<Branch>>(entity);
                        _dbSet.RemoveRange(entitys);
                        break;
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        var entitys = _mapper2.Map<IEnumerable<Contact>>(entity);
                        _dbSet.RemoveRange(entitys);
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }
            
        }

        public void Update(T entity)
        {
            switch (typeof(T).ToString())
            {
                case "ProjectDTO":
                    {
                        var _dbSet = _context.Set<Project>();
                        _dbSet.Update(_mapper2.Map<Project>(entity));
                        break;
                    }
                case "UserDTO":
                    {
                        var _dbSet = _context.Set<User>();
                        _dbSet.Update(_mapper2.Map<User>(entity));
                        break;
                    }
                case "BranchDTO":
                    {
                        var _dbSet = _context.Set<Branch>();
                        _dbSet.Update(_mapper2.Map<Branch>(entity));
                        break;
                    }
                case "ContactDTO":
                    {
                        var _dbSet = _context.Set<Contact>();
                        _dbSet.Update(_mapper2.Map<Contact>(entity));
                        break;
                    }
                default: { throw new NotImplementedException(); }
            }   
        }
    }
}
