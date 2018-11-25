using System.Collections.Generic;
using System.Linq;

namespace BuffteksWebApp.Models
{
    public class SeedDatabase
    {
        public static void Seed(AppDbContext db)
        {
            db.Database.EnsureCreated();

            if (db.Members.Any())
            {
                return;   // DB members table been seeded
            }

            // create add Members, save changes
            //Create at least ten Members
            var members = new List<Member>
                {
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    },
                    new Member
                    {

                    }
                };
            db.AddRange(members);
            db.SaveChanges();


            // create, add Clients, save changes
            //Create at least two clients
            var clients = new List<Client>
                {
                    new Client
                    {

                    },
                    new Client
                    {

                    }
                };

            db.AddRange(clients);
            db.SaveChanges();

            // create, add Project, save changes
            //Create at least two projects
            var projects = new List<Project>
                {
                    new Project
                    {

                    },
                    new Project
                    {

                    }
                };

            db.AddRange(projects);
            db.SaveChanges();

            //Assign Members and Clients to Projects
        }
    }
}
