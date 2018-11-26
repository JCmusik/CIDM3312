using System;
using System.Collections.Generic;

namespace BuffteksWebApp.Models
{
    /// <summary>
    /// A project for Members and Clients to collaborate on
    /// </summary>
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalHours { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
        public List<Member> Members { get; set; }
    }
}