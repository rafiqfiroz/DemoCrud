using DemoCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCrud.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person { Id=1,Name="Rafiq",LastName="Ahmed",Age=34},
                new Person { Id = 2, Name = "Shamim", LastName = "Ahmed", Age = 33 },
                new Person { Id = 3, Name = "Marium", LastName = "Ahmed", Age = 23 }
                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
