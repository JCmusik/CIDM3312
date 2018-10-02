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
                    var team = context.Teams.Include(s => s.Student);

                    foreach (var t in team)
                    {
                        t.Student = new Student
                        {
                            FirstName = fName,
                            LastName = lName,
                            Email = email,
                            PhoneNumber = phoneNumber
                        };
                        context.Add(t.Student);
                        context.SaveChanges();
                        Console.WriteLine($"Thank you {t.Student.FirstName}, your info has been saved to the database");
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
            using (var context = new AppDbContext())
            {
                foreach (var s in context.Students.AsNoTracking())
                {
                    Console.WriteLine();
                    Console.Write($"ID: {s.StudentID} ");
                    Console.WriteLine($"{s.FirstName} {s.LastName}");
                    Console.WriteLine($"{s.Email} {s.PhoneNumber}");
                }

            }
        }

        // Read and display project details
        public static void ReadProjectDetails()
        {
            using (var context = new AppDbContext())
            {
                foreach (var p in context.Projects.AsNoTracking().Include(c => c.Client).ThenInclude(o => o.Organization))
                {
                    Console.WriteLine($"\nProject Name: {p.Name}\n");
                    Console.WriteLine($"Organization: {p.Client.Organization.Name}");
                    Console.WriteLine($"Client Contact: {p.Client.FirstName} {p.Client.LastName}");
                    Console.WriteLine($"Email: {p.Client.Email}\nPhone #: {p.Client.Organization.PhoneNumber}\n");
                }
                foreach (var t in context.Teams.AsNoTracking())
                {
                    Console.WriteLine($"Team assigned to project: {t.Name}");
                    Console.WriteLine($"Team Leader: {t.TeamLeader}\n");   
                }
                Console.WriteLine($"List of team members:\n");
                foreach (var st in context.Students.AsNoTracking())
                {
                    Console.WriteLine($"{st.FirstName} {st.LastName}");
                    Console.WriteLine($"Email: {st.Email}\nPhone #: {st.PhoneNumber}\n");
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
                                    PhoneNumber = "XXX-XXX-XXXX",
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
                            PhoneNumber = "XXX-XXX-XXXX",
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
                using (var db = new AppDbContext())
                {
                    foreach (var st in db.Teams.Include(s => s.Student))
                    {
                       foreach (var s in students)
                       {
                           db.Add(s);
                       }
                    }
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