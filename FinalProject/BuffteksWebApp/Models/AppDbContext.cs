using System;
using Microsoft.EntityFrameworkCore;

namespace BuffteksWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // public DbSet<Member> Members { get; set; }
        // public DbSet<Client> Clients { get; set; }
        // public DbSet<Project> Projects { get; set; }

    }
}
