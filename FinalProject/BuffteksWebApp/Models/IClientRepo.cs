using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BuffteksWebApp.Models
{
    public interface IClientRepo
    {
        IQueryable<Client> Clients { get; set; }
    }
}