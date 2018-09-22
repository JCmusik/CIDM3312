using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Client object with a list of Projects
    /// </summary>
    public class Client : Person
    {
        public int ClientId { get; set; }
        [StringLength(70)]
        public string CompanyName { get; set; }
        public List<Project> Project { get; set; }
    }
}