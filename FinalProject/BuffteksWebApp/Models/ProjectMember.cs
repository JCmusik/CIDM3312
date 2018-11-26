namespace BuffteksWebApp.Models
{
    public class ProjectMember
    {
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }
}