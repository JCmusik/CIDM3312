using System.Linq;

namespace BuffteksWebApp.Models
{
    public interface IProjectMemberRepo
    {
        IQueryable<ProjectMember> ProjectMembers { get; set; }
    }
}