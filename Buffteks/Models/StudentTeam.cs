namespace Buffteks.Models
{
    public class StudentTeam
    {
        public int StudentId { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public Student Student { get; set; }
    }
}