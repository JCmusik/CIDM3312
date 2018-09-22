using Microsoft.EntityFrameworkCore;

namespace Buffteks.Models
{
    /// <summary>
    /// Database context for connecting to SQLite
    /// </summary>
    public class AppDbContext : DbContext
    {
        public DbSet<StudentTeam> StudentTeam { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Team> Team { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Buffteks.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
