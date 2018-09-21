using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Client : Person
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }
        public List<Project> Project { get; set; }
    }
}