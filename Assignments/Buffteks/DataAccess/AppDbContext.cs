using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace DataAccess.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Advisor> Advisors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Buffteks.db;");
        }
    }
}