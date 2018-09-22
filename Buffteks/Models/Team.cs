using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Team object with a list of Students
    /// </summary>
    public class Team
    {
        public int TeamId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string TeamLeader { get; set; }
        public List<Student> Students { get; set; }
        public List<StudentTeam> StudentTeam { get; set; }
    }
}