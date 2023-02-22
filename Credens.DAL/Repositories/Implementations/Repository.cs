using Credens.DAL.EF;
using Credens.DAL.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Credens.DAL.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly CredensDbContext _context;
       
        public Repository(CredensDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<T> GetAsync(Expression<Func<T,bool>> predicate)
        {
            return await _dbSet.FirstAsync(predicate);
        }

        public T Get(Expression<Func<T,bool>> predicate)
        {
            return _dbSet.First(predicate);
        }

        public IEnumerable<T> Select()
        {
            return _dbSet.ToList();
        }

        public async Task<List<T>> SelectAsync()
        {
            return await _dbSet.ToListAsync();
        }

         public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable<T>();
        }

        public void Add(T entity)
        {
             _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public async void AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async void AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public bool Any(Expression<Func<T, bool>> predicate)
        {
           return _dbSet.Any(predicate);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public T Find(params object[] keys)
        {
            return _dbSet.Find(keys);
        }

        public async Task<T> FindAsync(params object[] keys)
        {
            return await _dbSet.FindAsync(keys);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.First(predicate);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public T FirstOrDefault()
        {
            return _dbSet.FirstOrDefault();
        }

        public async Task<T> FirstOrDefaultAsync()
        {
            return await _dbSet.FirstOrDefaultAsync();
        }

        

        public IQueryable<IGrouping<K, T>> GroupBy<K>(Expression<Func<T, K>> predicate)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<T> OrderBy<K>(Expression<Func<T, K>> predicate)
        {
            throw new NotImplementedException();
        }



        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        
        public void Remove(T entities)
        {
            _dbSet.Remove(entities);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);        }
    }
}
