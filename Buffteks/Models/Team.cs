using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Student> StudentTeams { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}