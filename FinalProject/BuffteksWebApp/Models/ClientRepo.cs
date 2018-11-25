using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BuffteksWebApp.Models
{
    public class ClientRepo : IClientRepo
    {
        AppDbContext db;
        public ClientRepo(AppDbContext context)
        {
            db = context;
        }

        public IQueryable<Client> Clients { get; set; }
    }
}