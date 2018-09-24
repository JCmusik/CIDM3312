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
        public List<Project> Project { get; set; }
        public int OrgnaizationId { get; set; }
        public Organization Organization { get; set; }

    #endregion
       
    }
}