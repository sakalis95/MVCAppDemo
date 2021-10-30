using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MvcApp2.Models;

namespace MvcApp2
{
    //public class AppDbContext : DbContext
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Mindaugas" },
                new Employee() { Id = 2, Name = "Petras" }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Name = "Whiplash", Year = 2014, Director = "Damien Chazelle" },
                new Movie() { Id = 2, Name = "Pulp Fiction", Year = 1994, Director = "Quentin Tarantino" },
                new Movie() { Id = 3, Name = "The Good, the Bad and the Ugly", Year = 1966, Director = "Sergio Leone" },
                new Movie() { Id = 4, Name = "12 Angry Men", Year = 1957, Director = "Sidney Lumet" },
                new Movie() { Id = 5, Name = "Eternal Sunshine of the Spotless Mind", Year = 2004, Director = "Michel Gondry" },
                new Movie() { Id = 6, Name = "One Flew Over the Cuckoo's Nest", Year = 1975, Director = "Milos Forman" },
                new Movie() { Id = 7, Name = "The Green Mile", Year = 1999, Director = "Frank Darabont" },
                new Movie() { Id = 8, Name = "Life Is Beautiful", Year = 1997, Director = "Roberto Benigni" },
                new Movie() { Id = 9, Name = "Amélie", Year = 2001, Director = "Jean-Pierre Jeunet" },
                new Movie() { Id = 10, Name = "Léon: The Professional", Year = 1994, Director = "Luc Besson" }
                );
        }
    }
}
