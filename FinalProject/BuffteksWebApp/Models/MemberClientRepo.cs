using System.Linq;

namespace BuffteksWebApp.Models
{
    public class MemberClientRepo : IMemberClientRepo
    {
        public IQueryable<MemberClient> MemberClients { get; set; }
    }
}