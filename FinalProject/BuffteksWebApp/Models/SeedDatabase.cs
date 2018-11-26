using System;
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
                        FirstName = "John",
                        LastName = "Cunningham",
                        PhoneNumber = "806-555-1111",
                        Email = "john@email.com"

                    },
                    new Member
                    {
                        FirstName = "Mara",
                        LastName = "Kinoff",
                        PhoneNumber = "806-555-1112",
                        Email = "mara@email.com"
                    },
                    new Member
                    {
                        FirstName = "Gabby",
                        LastName = "Cumbest",
                        PhoneNumber = "806-555-1113",
                        Email = "gabby@email.com"
                    },
                    new Member
                    {
                        FirstName = "Amy",
                        LastName = "Saysouriyosack",
                        PhoneNumber = "806-555-1114",
                        Email = "amy@email.com"
                    },
                    new Member
                    {
                        FirstName = "Cesareo",
                        LastName = "Lona",
                        PhoneNumber = "806-555-1115",
                        Email = "cesar@email.com"
                    },
                    new Member
                    {
                        FirstName = "Michael",
                        LastName = "Matthews",
                        PhoneNumber = "806-555-1116",
                        Email = "michael@email.com"
                    },
                    new Member
                    {
                        FirstName = "Mason",
                        LastName = "McCollum",
                        PhoneNumber = "806-555-1117",
                        Email = "mason@email.com"
                    },
                    new Member
                    {
                        FirstName = "Catherine",
                        LastName = "McGovern",
                        PhoneNumber = "806-555-1118",
                        Email = "catherine@email.com"
                    },
                    new Member
                    {
                        FirstName = "Quan",
                        LastName = "Nyguyen",
                        PhoneNumber = "806-555-1119",
                        Email = "quan@email.com"
                    },
                    new Member
                    {
                        FirstName = "Vanessa",
                        LastName = "Valenzuela",
                        PhoneNumber = "806-555-1120",
                        Email = "vanessa@email.com"
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
                        FirstName = "",
                        LastName = "",
                        PhoneNumber = "",
                        Email = ""
                    },
                    new Client
                    {
                        FirstName = "",
                        LastName = "",
                        PhoneNumber = "",
                        Email = ""
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
                        Title = "",
                        BeginDate = DateTime.Parse("12/14/2018"),
                        EndDate = DateTime.Parse("12/14/2019"),
                        TotalHours = 2000

                    },
                    new Project
                    {
                        Title = "",
                        BeginDate = DateTime.Parse("12/14/2018"),
                        EndDate = DateTime.Parse("6/14/2019"),
                        TotalHours = 1000
                    }
                };

            db.AddRange(projects);
            db.SaveChanges();

            //Assign Members and Clients to Projects
        }
    }
}
