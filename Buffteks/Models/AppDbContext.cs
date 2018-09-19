using Microsoft.EntityFrameworkCore;

namespace Buffteks.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Buffteks.db;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentTeam>()
            .HasKey(t => new { t.StudentId, t.TeamId });

            modelBuilder.Entity<StudentTeam>()
            .HasOne(st => st.Student)
            .WithMany(s => s.StudentTeam)
            .HasForeignKey(st => st.StudentId);

            modelBuilder.Entity<StudentTeam>()
            .HasOne(st => st.Team)
            .WithMany(t => t.StudentTeam)
            .HasForeignKey(st => st.TeamId);
        }
    }
}