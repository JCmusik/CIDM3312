using System.Collections.Generic;

namespace Buffteks.Models
{
    public class Client : Person
    {
        public int ClientId { get; set; }
        public string ClientContactName { get; set; }
        public string Name { get; set; }
    }
}