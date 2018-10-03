using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Student> Students { get; set; }
        
    }
}