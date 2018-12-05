using System.Collections.Generic;

namespace BuffteksWebApp.Models
{
    public class ProjectDetailViewModel
    {
        public Project Project { get; set; }
        public List<Client> Clients { get; set; }
        public List<Member> Members { get; set; }
    }
}