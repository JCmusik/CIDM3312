namespace BuffteksWebApp.Models
{
    /// <summary>
    /// A member of the Buffteks
    /// </summary>
    public class Member : Person
    {
        public int MemberID { get; set; }
        public int ClientID { get; set; }
        public Client Clients { get; set; }

    }
}
