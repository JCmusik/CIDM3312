using System.Collections.Generic;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Team object with a list of Students
    /// </summary>
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string TeamLeader { get; set; }
        public List<Student> Students { get; set; }
        public List<StudentTeam> StudentTeam { get; set; }
    }
}