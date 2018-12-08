using System.Collections.Generic;

namespace BuffteksWebApp.Models
{
    public class ProjectDetailViewModel
    {
        public int ProjID { get; set; }
        public Project Project { get; set; }
        public int SelectID { get; set; }
        public List<Client> Clients { get; set; }
        public List<Member> Members { get; set; }
    }
}