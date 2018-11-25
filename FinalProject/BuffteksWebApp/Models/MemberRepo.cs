using System.Linq;

namespace BuffteksWebApp.Models
{
    public class MemberRepo : IMemberRepo
    {
        AppDbContext db;
        public MemberRepo(AppDbContext context)
        {
            db = context;
        }
        public IQueryable<Member> Members { get; set; }
    }
}