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
        }

        public static void CheckForDatabase()
        {
            Console.Write("Checking if database exists... ");
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
                Team = new Team
                {
                    Name = "Team 1",
                    Student =                    
                        new Student
                        {
                            FirstName = "John",
                            LastName = "Cunningham",
                            Email = "john@email.com",
                            PhoneNumber = "XXX-XXX-XXXX"
                        }
                    ,
                    TeamLeader = "Vanessa V"
                },
                TotalHours = 400                                
            };

            using (var context = new AppDbContext())
            {
                context.Add(project);

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
                            FirstName = "Vanessa",
                            LastName = "V",
                            Email = "vanessa@email.com",
                            PhoneNumber = "XXX-XXX-XXXX"
                        }
                };
                foreach (var s in students)
                {
                    context.Add(s);
                }
                                
                context.SaveChanges();
                System.Console.WriteLine("Changes saved");
            }
        }
        public static void HelpMe()
        {
            Console.WriteLine("\ndotnet run <command>\n");
            Console.WriteLine("Commands:\n");

            Console.WriteLine("\tcreate\t\tfor adding new student record");

            Console.WriteLine("\tread\t\tfor reading a project and listing the information about it");

            Console.WriteLine("\tupdate\t\tfor updating a student records info");

            Console.WriteLine("\tdelete\t\tfor deleting a student record");
            
            Console.WriteLine();

        }
    }
}