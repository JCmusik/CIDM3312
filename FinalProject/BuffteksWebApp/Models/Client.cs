using System.Collections.Generic;

namespace BuffteksWebApp.Models
{
    /// <summary>
    /// A client who provides a project to the Buffteks members
    /// </summary>
    public class Client : Person
    {
        public int ClientID { get; set; }
    }
}