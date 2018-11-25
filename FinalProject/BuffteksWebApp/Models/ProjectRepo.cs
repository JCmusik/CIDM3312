using System.Linq;

namespace BuffteksWebApp.Models
{
    public class ProjectRepo : IProjectRepo
    {
        public IQueryable<Project> Projects { get; set; }
    }
}