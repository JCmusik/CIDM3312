using System;
using System.Collections.Generic;
using System.Linq;
using Buffteks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Buffteks
{
    public static class Commands
    {

        // Add new Student
        public static void AddStudents()
        {
            CheckForDatabase();
            do
            {
                // Get user's first name
                Console.Write("Enter your first name: ");
                var fName = Console.ReadLine();
                // Get user's last name
                Console.Write("Enter your last name: ");
                var lName = Console.ReadLine();
                // Get user's email
                Console.Write("Enter your email: ");
                var email = Console.ReadLine();
                // Get user's phone number
                Console.Write("Enter you phone number: ");
                var phoneNumber = Console.ReadLine();


                using (var context = new AppDbContext())
                {
                    var team = context.Projects.Include(t => t.Team).ThenInclude(s => s.Student);

                    foreach (var t in team)
                    {
                        t.Team.Student = new Student
                        {
                            FirstName = fName,
                            LastName = lName,
                            Email = email,
                            PhoneNumber = phoneNumber
                        };
                        context.Add(t.Team.Student);
                        context.SaveChanges();
                        Console.WriteLine($"Thank you {t.Team.Student.FirstName}, your info has been saved to the database");
                    }                    
                }
                Console.Write("Would you like to add another student? (enter y or n) ");
                var response = Console.ReadLine();
                if (response != "y")
                    return;
            } while (true);
            
        }

        // Read student data from the database and display back to the user
        // TODO: Only reads out last record
        public static void ReadStudentsFromDB()
        {
            using (var context = new AppDbContext())
            {
                foreach (var s in context.Teams.AsNoTracking().Include(s => s.Student))
                {
                    Console.WriteLine($"{s.Student.FirstName} {s.Student.LastName}");
                    Console.WriteLine($"{s.Student.Email} {s.Student.PhoneNumber}");
                }
            }
        }

        public static void CheckForDatabase()
        {
            Console.Write("Determine if database exists... \n");
            Console.WriteLine(Commands.WipeSeed(true) ? "created database and seeded it." : "already exists.");
        }
        public static bool WipeSeed(bool onlyIfNoDatabase)
        {
            using (var db = new AppDbContext())
            {
                if (onlyIfNoDatabase && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                    return false;

                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                if (!db.Projects.Any())
                {
                    SeedDatabase(db);
                    Console.WriteLine("Seeded database");
                }
            }
            return true;
        }

        public static void SeedDatabase(this AppDbContext db)
        {
            var project = new Project
            {
                Name = "Buffteks App",
                Client = new Client
                {
                    FirstName = "Craig",
                    LastName = "Willfong",
                    Email = "cwilfong@kidsinc.org",
                    Organization = new Organization
                        {
                            Name = "Kids Inc.",
                            Email = "info@kidsinc.org",
                            PhoneNumber = "806-376-5936"
                        }
                },
                TotalHours = 400,
                Team = new Team
                {
                    Name = "Team 1",
                    TeamLeader = "Vanessa Valenzuela",
                    Student = new Student
                    {
                        FirstName = "Vanessa",
                        LastName = "Valenzuela",
                        Email = "vanessa@email.com",
                        PhoneNumber = "XXX-XXX-XXXX"
                    }
                }                               
            };

            
            var students =
                    new List<Student>
                    {
                        new Student
                        {
                            FirstName = "Mara",
                            LastName = "Kinoff",
                            Email = "mara@email.com",
                            PhoneNumber = "XXX-XXX-XXXX"
                        },
                        new Student
                        {
                            FirstName = "John",
                            LastName = "Cunningham",
                            Email = "john@email.com",
                            PhoneNumber = "XXX-XXX-XXXX"
                        }
                        
                    };

            

            
            using (var context = new AppDbContext())
            {
                context.Add(project);

                context.SaveChanges();
                System.Console.WriteLine("Project added");
            }

            using (var context = new AppDbContext())
            {
                var team = context.Teams;
                    foreach (var t in team)
                    {
                        foreach (var s in students)
                        {
                            t.Student = s;
                            context.Add(t.Student);
                        }
                    }
                context.SaveChanges();
                System.Console.WriteLine("Students added");
            }
        }
        public static void HelpMe()
        {
            Console.WriteLine("\ndotnet run <command>\n");
            Console.WriteLine("Commands:\n");

            Console.WriteLine("\tcreate\t\tfor adding new student record");

            Console.WriteLine("\tread\t\tfor reading and displaying student records");

            Console.WriteLine("\tupdate\t\tfor updating a student records info");

            Console.WriteLine("\tdelete\t\tfor deleting a student record");
            
            Console.WriteLine();

        }
    }
}