
using AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;

namespace Credens.DAL.Repositories.Implementations
{
    public class ProjectRepository : IRepository<ProjectDTO>
    {
        private readonly DbSet<Project> _dbSet;
        private readonly CredensDbContext _context;
        private readonly IMapper _mapper;
        
        public ProjectRepository(CredensDbContext context, IMapper mapper)
        {
            _mapper= mapper;
            _context = context;
            _dbSet = context.Set<Project>();
        }

        public IQueryable<ProjectDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProjectDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public IQueryable<ProjectDTO> GetAll()
        //{
        //   // return  _dbSet.AsQueryable().Cast<ProjectDTO>();
        //   throw new NotImplementedException();
        //}

        //public ProjectDTO GetById(int id)
        //{
        //    // return _dbSet.AsQueryable().Cast<User>().FirstOrDefault(x => x.UserId == id);
        //    throw new Exception();
        //}

        public async Task<IEnumerable<ProjectDTO>> GetListAsync()
        {
            var rezult = _mapper.Map<IEnumerable<ProjectDTO>>(await _dbSet.ToListAsync());
           
            return rezult;
        }

       


















        //public async Task<ProjectDTO> GetAsync(Expression<Func<ProjectDTO, bool>> predicate)
        //{
        //    return await _dbSet.FirstAsync(predicate);
        //}

        //public ProjectDTO Get(Expression<Func<ProjectDTO, bool>> predicate)
        //{
        //    return _dbSet.First(predicate);
        //}

        //public IEnumerable<ProjectDTO> Select()
        //{
        //    return _dbSet.ToList();
        //}

        //public async Task<List<ProjectDTO>> SelectAsync()
        //{
        //    return await _dbSet.ToListAsync();
        //}

        // public IQueryable<ProjectDTO> GetAll()
        //{
        //    return _dbSet.AsQueryable<ProjectDTO>();
        //}

        //public void Add(ProjectDTO entity)
        //{
        //     _dbSet.Add(entity);
        //}

        //public void AddRange(IEnumerable<ProjectDTO> entities)
        //{
        //    _dbSet.AddRange(entities);
        //}

        //public async Task<bool> AddAsync(ProjectDTO entity)
        //{
        //    await _dbSet.AddAsync(entity);

        //    return true;
        //}

        //public async void AddRangeAsync(IEnumerable<ProjectDTO> entities)
        //{
        //    await _dbSet.AddRangeAsync(entities);
        //}

        //public bool Any(Expression<Func<ProjectDTO, bool>> predicate)
        //{
        //   return _dbSet.Any(predicate);
        //}

        //public void Delete(ProjectDTO entity)
        //{
        //    _dbSet.Remove(entity);
        //}

        //public void DeleteRange(IEnumerable<ProjectDTO> entity)
        //{
        //    _dbSet.RemoveRange(entity);
        //}

        //public ProjectDTO Find(params object[] keys)
        //{
        //    return _dbSet.Find(keys);
        //}

        //public async Task<ProjectDTO> FindAsync(params object[] keys)
        //{
        //    return await _dbSet.FindAsync(keys);
        //}

        //public ProjectDTO First(Expression<Func<ProjectDTO, bool>> predicate)
        //{
        //    return _dbSet.First(predicate);
        //}

        //public ProjectDTO FirstOrDefault(Expression<Func<ProjectDTO, bool>> predicate)
        //{
        //    return _dbSet.FirstOrDefault(predicate);
        //}

        //public ProjectDTO FirstOrDefault()
        //{
        //    return _dbSet.FirstOrDefault();
        //}

        //public async Task<ProjectDTO> FirstOrDefaultAsync()
        //{
        //    return await _dbSet.FirstOrDefaultAsync();
        //}



        //public IQueryable<IGrouping<K, ProjectDTO>> GroupBy<K>(Expression<Func<ProjectDTO, K>> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public IOrderedQueryable<ProjectDTO> OrderBy<K>(Expression<Func<ProjectDTO, K>> predicate)
        //{
        //    throw new NotImplementedException();
        //}



        //public void RemoveRange(IEnumerable<ProjectDTO> entities)
        //{
        //    _dbSet.RemoveRange(entities);
        //}

        //public void Remove(ProjectDTO entities)
        //{
        //    _dbSet.Remove(entities);
        //}

        //public void SaveChanges()
        //{
        //    _context.SaveChanges();
        //}

        //public async Task SaveChangesAsync()
        //{
        //    await _context.SaveChangesAsync();
        //}

        //public void Update(ProjectDTO entity)
        //{
        //    _dbSet.Update(entity);       
        //}
    }
}
