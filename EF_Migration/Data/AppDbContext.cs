using EF_Migration.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF_Migration.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Instructor> Instructors { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;

        //public AppDbContext(DbContextOptions options):base(options) { }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string? ConnString = new ConfigurationBuilder().AddJsonFile("D:\\Programming\\EF\\EF_Migration\\appSettings.json")
                                     .Build().GetSection("ConnString").Value;



            optionsBuilder.UseSqlServer(ConnString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Course).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<SnapShot>();
        }
    }
}