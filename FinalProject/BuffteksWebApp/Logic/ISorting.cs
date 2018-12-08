using System.Linq;
using BuffteksWebApp.Models;

namespace BuffteksWebApp.Logic
{
    public interface ISorting
    {
        IQueryable<Person> Sort(AppDbContext db, string sortOrder, string type);
        ProjectDetailViewModel ProjectJoinMembersClients(AppDbContext db, Project project);
        ProjectDetailViewModel MembersClientsNotInProject(AppDbContext db, Project project);
    }
}