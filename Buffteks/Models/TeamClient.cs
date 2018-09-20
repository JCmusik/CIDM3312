using System.ComponentModel.DataAnnotations;

namespace Buffteks.Models
{
    public class TeamClient
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}