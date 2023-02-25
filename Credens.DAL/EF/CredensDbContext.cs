using Credens.DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Credens.DAL.EF
{
    public class CredensDbContext : DbContext
    {
        public CredensDbContext() { }   
       
        public CredensDbContext(DbContextOptions<CredensDbContext> options) : base(options) { }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
    }

    public class CredensDbContextFactory : IDesignTimeDbContextFactory<CredensDbContext>
    {
        public CredensDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CredensDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-4JMLDIS;Database=Credens19.02;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

            return new CredensDbContext(optionsBuilder.Options);
        }
    }
}
