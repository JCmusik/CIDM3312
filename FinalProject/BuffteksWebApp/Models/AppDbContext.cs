using System;
using Microsoft.EntityFrameworkCore;

namespace BuffteksWebApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberClient>()
           .HasKey(mc => new { mc.MemberID, mc.ClientID });
        }
        public DbSet<MemberClient> MemberCLients { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}