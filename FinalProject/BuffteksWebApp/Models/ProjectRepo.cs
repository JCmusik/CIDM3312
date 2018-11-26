using System.Linq;

namespace BuffteksWebApp.Models
{
    public class ProjectRepo : IProjectRepo
    {
        AppDbContext db;
        public ProjectRepo(AppDbContext context)
        {
            db = context;
        }

        public IQueryable<Project> Projects { get; set; }
    }
}