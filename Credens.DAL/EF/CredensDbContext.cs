using Credens.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Credens.DAL.EF
{
    public class CredensDbContext : DbContext
    {
        public CredensDbContext(DbContextOptions<CredensDbContext> options) : base(options) { }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
