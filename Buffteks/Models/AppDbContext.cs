using Microsoft.EntityFrameworkCore;

namespace Buffteks.Models
{
    /// <summary>
    /// Database context for connecting to SQLite
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<StudentTeam> StudentTeam { get; set; }
        public DbSet<Project> Project { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Buffteks.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API's to map PK/FK of the extra entity class to their respective classes
            /// <see cref="https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many">
            
            modelBuilder.Entity<StudentTeam>()
            .HasKey(t => new { t.StudentId, t.TeamId });

            modelBuilder.Entity<StudentTeam>()
            .HasOne(s => s.Student)
            .WithMany(st => st.StudentTeam)
            .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentTeam>()
            .HasOne(t => t.Team)
            .WithMany(st => st.StudentTeam)
            .HasForeignKey(t => t.TeamId);

        }
    }
}
