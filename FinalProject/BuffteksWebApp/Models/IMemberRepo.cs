using System.Linq;

namespace BuffteksWebApp.Models
{
    public interface IMemberRepo
    {
        IQueryable<Member> Members { get; set; }
    }
}