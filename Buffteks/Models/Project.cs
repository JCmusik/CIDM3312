using System;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Project object
    /// </summary>
    public class Project
    {
    #region Properties

        // primary key
        public int ProjectId { get; set; }
        [MaxLength(100)] // sets max length for property
        public string ProjectName { get; set; }
        public double TotalHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Fk to connect to Client class
        public int ClientId { get; set; }

        // FK to onnect to Team class
        public int TeamId { get; set; }
        
        // Navigational properties used for FK mapping
        public Client Client { get; set; }
        public Team Team { get; set; }

    #endregion
        
    }
}