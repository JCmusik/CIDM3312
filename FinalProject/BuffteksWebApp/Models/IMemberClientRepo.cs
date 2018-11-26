using System.Linq;

namespace BuffteksWebApp.Models
{
    public interface IMemberClientRepo
    {
        IQueryable<MemberClient> MemberClients { get; set; }
    }
}