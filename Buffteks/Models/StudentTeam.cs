namespace Buffteks.Models
{
    /// <summary>
    /// Extra entity for many to many relationship of Student and Team 
    /// </summary>
    /// <reference>Fluent API's found in <cref="AppDbContext.cs"> in the <cref="OnModelCreating"> model builder</reference>
    public class StudentTeam
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}