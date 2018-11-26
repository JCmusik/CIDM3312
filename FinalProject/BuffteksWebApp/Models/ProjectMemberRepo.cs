using System.Linq;

namespace BuffteksWebApp.Models
{
    public class ProjectMemberRepo : IProjectMemberRepo
    {
        public IQueryable<ProjectMember> ProjectMembers { get; set; }
    }
}