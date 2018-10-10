using Microsoft.EntityFrameworkCore;

namespace LINQPractice.Models
{
    public class AppDbContext : DbContext
    {
        private const string connectionString = @"Data Source=LINQ.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString);
        }

        
    }
}