using System.Collections.Generic;

namespace inClassPractice.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Student> StudentTeams { get; set; }
    }
}