namespace Buffteks.Models
{
    /// <summary>
    /// Extra entity to handle the many to many relationship of Student and Team classes
    /// </summary>
    /// <reference>See Fluent API's comment found in the <see cref="AppDbContext"> class in the OnModelCreating modelbuilder</reference>
    public class StudentTeam
    {
    #region Properties

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

    #endregion
    }
}