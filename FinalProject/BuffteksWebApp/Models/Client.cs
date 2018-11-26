using System.Collections.Generic;

namespace BuffteksWebApp.Models
{
    /// <summary>
    /// A client who provides a project to the Buffteks members
    /// </summary>
    public class Client : Person
    {
        public int ClientID { get; set; }
        List<Project> Projects { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
    }
}