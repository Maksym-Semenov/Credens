
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Credens.DAL.AutoMapper;
using Credens.DAL.Domain.Entities;
using Credens.DAL.EF;
using Credens.Infrastructure.DTO;
using Credens.Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Credens.DAL.Repositories.Implementations
{
    public class ProjectRepository : IRepository<ProjectDTO>
    {
        private readonly IMapper _mapper;
        private readonly DbSet<Project> _dbSet;
        private readonly CredensDbContext _context;
        
        public ProjectRepository(CredensDbContext context)
        {
            _mapper = CredensMapper<Project, ProjectDTO>.MapperInit();
            _context = context;
            _dbSet = context.Set<Project>();
        }

        public ProjectDTO Get(Expression<Func<ProjectDTO, bool>> predicate)
        {
            return _dbSet.ProjectTo<ProjectDTO>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefault();
        }

        public IQueryable<ProjectDTO> GetAll()
        {
            return _dbSet.ProjectTo<ProjectDTO>(_mapper.ConfigurationProvider);
        }

        public async Task<ProjectDTO> GetAsync(Expression<Func<ProjectDTO, bool>> predicate)
        {
            return await _dbSet.ProjectTo<ProjectDTO>(_mapper.ConfigurationProvider).Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProjectDTO>> GetListAsync()
        {
            var rezult = _mapper.Map<IEnumerable<ProjectDTO>>(await _dbSet.ToListAsync()); 
            
            return rezult;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
           await _context.SaveChangesAsync();
        }

        public void Add(ProjectDTO entity)
        {
            Project project =_mapper.Map<Project>(entity);
            _dbSet.Add(project);
        }

        public async Task AddAsync(ProjectDTO entity)
        {
            Project project = _mapper.Map<Project>(entity);
            await _dbSet.AddAsync(project);
        }

          
        public void Delete(ProjectDTO entity)
        {
            Project project = _mapper.Map<Project>(entity);
            _dbSet.Remove(project);
        }

        public void DeleteRange(IEnumerable<ProjectDTO> entity)
        {
            var entitys = _mapper.Map<IEnumerable<Project>>(entity);
            _dbSet.RemoveRange(entitys);
        }

        public void Update(ProjectDTO entity)
        {
            var newEntity = _mapper.Map<Project>(entity);
            _dbSet.Update(newEntity);
        }
    }
}
