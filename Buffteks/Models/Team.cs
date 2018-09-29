using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string TeamLeader { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public List<Student> Students { get; set; }
    }
}