using Microsoft.EntityFrameworkCore;
namespace MvcMovie.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
    }
    
}