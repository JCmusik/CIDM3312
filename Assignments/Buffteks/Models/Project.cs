using System;

namespace Models.Models
{
    public class Project
    {
        #region Properties
            
            public int ProjectId { get; set; }
            public string Name { get; set; }
            public double TotalHours { get; set; }
            public int TeamID { get; set; }
            public Team Team { get; set; }

            public int ClientID { get; set; }
            public Client Client { get; set; }


        #endregion

        #region Methods
            
            public override string ToString() => $"Project: {this.Name}\n";

        #endregion
    }
}