using System.Linq;

namespace BuffteksWebApp.Models
{
    public interface IProjectRepo
    {
        IQueryable<Project> Projects { get; set; }
    }
}