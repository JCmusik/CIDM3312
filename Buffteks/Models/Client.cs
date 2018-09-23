using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Client object with a list of Projects
    /// </summary>
    public class Client : Person
    {
    #region Properties

        // Primary Key
        public int ClientId { get; set; }
        
        [MaxLength(70)] // sets max length of property
        public string CompanyName { get; set; }
        public List<Project> Project { get; set; }

    #endregion
       
    }
}