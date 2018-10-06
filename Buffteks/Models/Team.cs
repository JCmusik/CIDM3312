using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Team
    {
        #region Properties

            public int TeamID { get; set; }
            public string Name { get; set; }
            public string TeamLeader { get; set; }
            public int StudentID { get; set; }
            public Student Student { get; set; }
            public List<Student> Students { get; set; }
            
        #endregion

        #region Methods
            
            public override string ToString() => $"Team name: {this.Name}\nTeam Leader: {this.TeamLeader}\n";

        #endregion
    }
}