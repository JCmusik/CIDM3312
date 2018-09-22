using System;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Project object
    /// </summary>
    public class Project
    {
        public int ProjectId { get; set; }
        [StringLength(100)]
         public string ProjectName { get; set; }
         public double TotalHours { get; set; }
         public DateTime StartDate { get; set; }
         public DateTime EndDate { get; set; }
         public int ClientId { get; set; }
         public Client Client { get; set; }
         public int TeamId { get; set; }
         public Team Team { get; set; }
    }
}