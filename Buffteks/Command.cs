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
                Console.WriteLine();
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
                    
                    var student = context.Teams.Include(s => s.Student);

                    foreach (var s in student)
                    {
                        var std = new Student
                        {
                            FirstName = fName,
                            LastName = lName,
                            Email = email,
                            PhoneNumber = phoneNumber
                        };
                        context.Add(std);
                        context.SaveChanges();
                        Console.WriteLine($"Thank you {std.FirstName}, your info has been saved to the database");  
                    }             
                    
                         
                }
                Console.Write("Would you like to add another student? (enter y or n) ");
                var response = Console.ReadLine();
                if (response != "y")
                    return;
            } while (true);
            
        }

        // Read student data from the database and display back to the user
        public static void ReadStudentsFromDB()
        {
            CheckForDatabase();
            using (var context = new AppDbContext())
            {
                foreach (var s in context.Students.AsNoTracking())
                {
                    Console.WriteLine();
                    Console.Write(s);
                }

            }
        }

        // Read and display project details
        public static void ReadProjectDetails()
        {
            CheckForDatabase();
            using (var context = new AppDbContext())
            {
                foreach (var p in context.Projects.AsNoTracking().Include(c => c.Client).ThenInclude(o => o.Organization))
                {
                    Console.WriteLine(p);
                    Console.WriteLine(p.Client);
                }
                foreach (var a in context.Advisors)
                {
                    Console.WriteLine("---Advisor---");
                    Console.WriteLine(a);
                }
                foreach (var t in context.Teams.AsNoTracking())
                {
                    Console.WriteLine(t);
                }
                Console.WriteLine($"----List of team members----");
                foreach (var st in context.Students.AsNoTracking())
                {
                    Console.WriteLine(st);
                }
            }
        }

        public static void CheckForDatabase()
        {
            Console.Write("Determine if database exists... \n");
            Console.WriteLine(Commands.WipeSeed(true) ? "created database and seeded it." : "already exists.\n");
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

        // Seeds database with data
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
                    Name = "Team Buffteks",
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

            db.Add(project);
            db.SaveChanges();
            System.Console.WriteLine("Project added");
            CreateStudents();
        }

        // Creates list of students and adds them to the database
        private static void CreateStudents()
        {

            var students = new List<Student>
                {
                    new Student
                        {
                            FirstName = "Gabrielle",
                            LastName = "Ashley",
                            Email = "gabrielle@email.com",
                            PhoneNumber = "XXX-XXX-XXXX"
                        },
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
                            PhoneNumber = "XXX-XXX-XXXX",
                        }
                };  

                var advisor = new Advisor
                {
                    FirstName = "Jeffry",
                    LastName = "Babb",
                    Email = "jbabb@wtamu.edu",
                    PhoneNumber = "806-651-2440"
                };

                using (var db = new AppDbContext())
                {
                    foreach (var st in db.Teams.Include(s => s.Student))
                    {
                       foreach (var s in students)
                       {
                           db.Add(s);
                       }
                    }
                db.Advisors.Add(advisor);
                db.SaveChanges();
                Console.WriteLine("Students added");
                }
               
        }

        // Delete student form Db
        public static void DeleteStudent()
        {
            ReadStudentsFromDB();
            Console.Write("\nEnter the ID of the student you want to delete: ");
            var response = Int32.Parse(Console.ReadLine());

            using (var context = new AppDbContext())
            {
                var studentToRemove = context.Students.Where(id => id.StudentID == response);
                foreach (var st in studentToRemove)
                {
                    context.Remove(st);
                    context.SaveChanges();
                }
                Console.WriteLine($"Student {response} removed");
            }

            ReadStudentsFromDB();
        }

        // Update Student Phone #
        public static void UpdateStudentPhoneNumber()
        {
            ReadStudentsFromDB();
            Console.Write("\nEnter the ID of the student phone # you want to update: ");
            var studentToUpdate = Int32.Parse(Console.ReadLine());
            Console.Write("\nEnter the new phone #: ");
            var newPhoneNumber = Console.ReadLine();

            using (var context = new AppDbContext())
            {
                foreach (var s in context.Students.Where(id => id.StudentID == studentToUpdate))
                {
                    s.PhoneNumber = newPhoneNumber;
                }
                context.SaveChanges();
                Console.WriteLine($"Phone recored has been updated");
            }
            ReadStudentsFromDB();
        }

        // Displays commands to run from the console
        public static void HelpMe()
        {
            Console.WriteLine("\ndotnet run <command>\n");
            Console.WriteLine("Commands:\n");

            Console.WriteLine("\tcreate\t\tfor adding new student record");

            Console.WriteLine("\tread\t\tfor reading and displaying student records");

            Console.WriteLine("\tupdate\t\tfor updating a student phone record info");

            Console.WriteLine("\tdelete\t\tfor deleting a student record");

            Console.WriteLine("\tproject\t\tdisplay list of project details");
            
            Console.WriteLine();

        }
    }
}