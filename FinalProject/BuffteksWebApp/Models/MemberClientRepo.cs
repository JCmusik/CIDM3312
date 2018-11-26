using System.Linq;

namespace BuffteksWebApp.Models
{
    public class MemberClientRepo : IMemberClientRepo
    {
        AppDbContext db;
        public MemberClientRepo(AppDbContext context)
        {
            db = context;
        }
        public IQueryable<MemberClient> MemberClients { get; set; }
    }
}