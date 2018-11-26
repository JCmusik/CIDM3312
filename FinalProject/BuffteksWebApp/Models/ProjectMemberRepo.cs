using System.Linq;

namespace BuffteksWebApp.Models
{
    public class ProjectMemberRepo : IProjectMemberRepo
    {
        AppDbContext db;
        public ProjectMemberRepo(AppDbContext context)
        {
            db = context;
        }

        public IQueryable<ProjectMember> ProjectMembers { get; set; }
    }
}