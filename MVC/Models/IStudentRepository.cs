using System.Linq;
using MVC.Models;

namespace MVC.Models
{
    public interface IStudentRepository
    {
        IQueryable<Student> Students { get; }
        IQueryable<Team> Teams { get; }
    }
}