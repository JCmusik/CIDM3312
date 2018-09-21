namespace Buffteks.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string TeamLeader { get; set; }
        public List<Student> Students { get; set; }
    }
}