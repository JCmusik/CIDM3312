using System.Collections.Generic;

namespace Buffteks.Models
{
    /// <summary>
    /// Defines a Client object with a list of Projects
    /// </summary>
    public class Client : Person
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public List<Project> Project { get; set; }
    }
}