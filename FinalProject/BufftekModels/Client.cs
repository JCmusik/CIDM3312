using System.Collections.Generic;

namespace BufftekModels
{
    /// <summary>
    /// A client who provides a project to the Buffteks members
    /// </summary>
    public class Client : Person
    {
        public int ClientID { get; set; }
        List<Project> Projects { get; set; }
    }
}