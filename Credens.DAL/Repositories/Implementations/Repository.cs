
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Credens.DAL.AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.DAL.Type_selection;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Credens.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly IMapper _mapper;
        private readonly CredensDbContext _context;
  
        public Repository(CredensDbContext context)
        {
            _mapper = CredensMapper<T>.MapperInit();
            _context = context;
        }


        public static DbSet<T> GetDbSet<T>(DbContext _context) where T : class
        {
          return  (DbSet<T>)_context.GetType().GetMethod("Set", types: Type.EmptyTypes).MakeGenericMethod(typeof(T)).Invoke(_context, null);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            Type t = typeof(T);
            var _dbSet = _context.Set(t.GetType());
            return  _dbSet.ProjectTo<T>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            switch (typeof(TOut).ToString())
            {
                case "ProjectDTO":
                    {
                        DbSet<Project> _dbSet = _context.Set<Project>();
                        return _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider);
                    }
                case "BranchDTO":
                    {
                        DbSet<Branch> _dbSet = _context.Set<Branch>();
                        return _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider);
                    }
                case "ContactDTO":
                    {
                        DbSet<Contact> _dbSet = _context.Set<Contact>();
                        return _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider);
                    }
                case "UserDTO":
                    {
                        DbSet<User> _dbSet = _context.Set<User>();
                        return _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider);
                    }
                default:
                    { throw new Exception(); }
            }
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            switch (typeof(TOut).ToString())
            {
                case "ProjectDTO":
                    {
                        DbSet<Project> _dbSet = _context.Set<Project>();
                        return await _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "BranchDTO":
                    {
                        DbSet<Branch> _dbSet = _context.Set<Branch>();
                        return await _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "ContactDTO":
                    {
                        DbSet<Contact> _dbSet = _context.Set<Contact>();
                        return await _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                case "UserDTO":
                    {
                        DbSet<User> _dbSet = _context.Set<User>();
                        return await _dbSet.ProjectTo<TOut>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
                    }
                default:
                    { throw new Exception(); }
            }
        }

        public async Task<IEnumerable<T>> GetListAsync()
        {
            return _mapper.Map<IEnumerable<T>>(await _dbSet.ToListAsync()); 
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
            _dbSet.Add(_mapper.Map<T>(entity));
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(_mapper.Map<T>(entity));
        }

          
        public void Delete(T entity)
        {
            _dbSet.Remove(_mapper.Map<T>(entity));
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            var entitys = _mapper.Map<IEnumerable<T>>(entity);
            _dbSet.RemoveRange(entitys);
        }

        public void Update(T entity)
        {
            _dbSet.Update(_mapper.Map<T>(entity));
        }


        
        
    }
}
