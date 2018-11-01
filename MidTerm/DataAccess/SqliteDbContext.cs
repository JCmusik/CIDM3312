using BookLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        private const string ConnectionString = "Data Source=MidTerm.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }
    }
}