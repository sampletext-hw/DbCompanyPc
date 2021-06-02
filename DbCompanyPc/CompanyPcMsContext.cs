using DbCompanyPc.Models;
using Microsoft.EntityFrameworkCore;

namespace DbCompanyPc
{
    public class CompanyPcMsContext : DbContext
    {
        public CompanyPcMsContext()
        {
        }

        public CompanyPcMsContext(DbContextOptions<CompanyPcMsContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=CompanyPc;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerToPartElement>().HasKey(cpe => new {cpe.ComputerId, cpe.PartElementId});
            modelBuilder.Entity<ComputerToSoftElement>().HasKey(cse => new {cse.ComputerId, cse.SoftElementId});
            modelBuilder.Entity<Department>().HasMany(d => d.ParentOf).WithOne(dr => dr.Department).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Department>().HasMany(d => d.ChildOf).WithOne(dr => dr.Parent).OnDelete(DeleteBehavior.NoAction);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerToPartElement> ComputerToPartElements { get; set; }
        public DbSet<ComputerToSoftElement> ComputerToSoftElements { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentRelation> DepartmentRelations { get; set; }
        public DbSet<LocalNetwork> LocalNetworks { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartElement> PartElements { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Soft> Softs { get; set; }
        public DbSet<SoftElement> SoftElements { get; set; }
    }
}