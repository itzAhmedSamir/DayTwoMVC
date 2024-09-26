using DayTwoMVC.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DayTwoMVC.DAL.DB
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MVC2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<User>Users { get; set; }
        public DbSet<Post>Posts { get; set; }
    }
}
