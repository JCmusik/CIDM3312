using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Team object with a list of Students
    /// </summary>
    public class Team
    {
    #region Properties
    
        //primary key
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string TeamLeader { get; set; }

        public List<Student> Students { get; set; }

        public List<StudentTeam> StudentTeam { get; set; }

        /// <summary>
        /// Used for Many to Many Relationships between Student and Team classes
        /// <see cref="https://docs.microsoft.com/en-us/ef/core/modeling/relationships#many-to-many">
        /// </summary>
       

    #endregion
    }
}