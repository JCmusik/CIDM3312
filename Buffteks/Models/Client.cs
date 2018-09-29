namespace Buffteks.Models
{
    public class Client : Person
    {
        public int ClientID { get; set; }
        public int OrganizationID { get; set; }
        public Organization Organization { get; set; }
    }
}