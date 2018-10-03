using System.Linq;

namespace MVC.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private AppDbContext context;
        public EFStudentRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Student> Students => context.Students;
        public IQueryable<Team> Teams => context.Teams;
    }
}