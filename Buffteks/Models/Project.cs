using System;

namespace Buffteks.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public DateTime TotalHours { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }

        public int ClientID { get; set; }
        public Client Client { get; set; }
    }
}