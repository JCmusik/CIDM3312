using System.Linq;
using DataAccess;

namespace BufftekModels
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                if (db.Members.Any())
                {
                    return;   // DB members table been seeded
                }

                // create add Members, save changes

                // create, add Clients, save changes

                // create, add Project, save changes


            }
        }
    }
}