using System;
using System.Collections.Generic;
using System.Linq;
using Models.Models;
using DataAccess.Models;
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
                // Get user's number of table they sit at
                Console.Write("Enter your table number: ");
                var tableNumber = byte.Parse(Console.ReadLine());

                
                using (var context = new AppDbContext())
                {
                    var std = new Student
                        {
                            TeamID = 1,
                            FirstName = fName,
                            LastName = lName,
                            Email = email,
                            PhoneNumber = phoneNumber,
                            TableNumber = tableNumber
                        };

                    var students = context.Teams.Include(s => s.Students);
                    
                    foreach (var t in students)
                    {
                        context.Add(std);
                    }             
                    context.SaveChanges();
                    Console.WriteLine($"Thank you {std.FirstName}, your info has been saved to the database");
                         
                }
                Console.Write("Would you like to add another student? (enter y or n) ");
                var response = Console.ReadLine();
                if (response != "y")
                    return;
            } while (true);
            
        }

        // Read student data from the database and display back to the user
        public static void ReadStudentsFromDB(AppDbContext context)
        {
            CheckForDatabase();
                if (!context.Students.Include(s => s.Team).Any())
                {
                    Console.WriteLine("No students in the database\n");
                }
                else
                {
                    foreach (var s in context.Students.AsNoTracking())
                    {
                        Console.WriteLine();
                        Console.Write(s);
                    }
                    Console.WriteLine();
                }
        }

        // Read and display project details
        public static void ReadProjectDetails()
        {
            CheckForDatabase();
            using (var context = new AppDbContext())
            {
                if(!context.Projects.Any())
                {
                    Console.WriteLine("No project exists");
                }
                else
                {
                    var  projectDetails = context.Projects.AsNoTracking().Include(c => c.Client).ThenInclude(o => o.Organization);
                    foreach (var p in projectDetails)
                    {
                        Console.WriteLine(p);
                        Console.WriteLine(p.Client);
                        Console.WriteLine($"Organization Phone Number: {p.Client.Organization.PhoneNumber}\n");
                    }

                    foreach (var t in context.Teams.AsNoTracking().Include(a => a.Advisor))
                    {
                        Console.WriteLine("---Advisor---");
                        Console.WriteLine(t.Advisor);
                        Console.WriteLine(t);
                    }
                    Console.WriteLine($"----List of team members----");
                    foreach (var st in context.Students.AsNoTracking())
                    {
                        Console.WriteLine(st);
                    }

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
                    PhoneNumber = "XXX-XXX-XXXX",
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
                    Advisor = new Advisor
                    {
                        Title = "Professor",
                        FirstName = "Jeffry",
                        LastName = "Babb",
                        Email = "jbabb@wtamu.edu",
                        PhoneNumber = "806-651-2440"
                    },
                    Students = new List<Student>
                    {
                        new Student
                        {
                            FirstName = "Vanessa",
                            LastName = "Valenzuela",
                            Email = "vanessa@hotmail.com",
                            PhoneNumber = "XXX-XXX-XXXX",
                            TableNumber = 3
                        },
                        new Student
                        {
                            FirstName = "Gabrielle",
                            LastName = "Ashley",
                            Email = "gabrielle@hotmail.com",
                            PhoneNumber = "XXX-XXX-XXXX",
                            TableNumber = 3
                        },
                    new Student
                        {
                            FirstName = "Mara",
                            LastName = "Kinoff",
                            Email = "mara@email.com",
                            PhoneNumber = "XXX-XXX-XXXX",
                            TableNumber = 2
                        },
                    new Student
                        {
                            FirstName = "John",
                            LastName = "Cunningham",
                            Email = "john@email.com",
                            PhoneNumber = "XXX-XXX-XXXX",
                            TableNumber = 2
                        }
                    }
                }
            };  

            db.Add(project);
            db.SaveChanges();
            System.Console.WriteLine("Project added");
        }


        // Delete student form Db
        public static void DeleteStudent()
        {
            CheckForDatabase();

            using (var context = new AppDbContext())
            {
                if(!context.Students.Any())
                {
                    Console.WriteLine("No students in database\n");
                }
                else
                {
                    ReadStudentsFromDB(context);
                    Console.Write("\nEnter the ID of the student you want to delete: ");
                    var response = Int32.Parse(Console.ReadLine());
                    var studentToRemove = context.Students.Where(id => id.StudentID == response);
                    foreach (var st in studentToRemove)
                    {
                        context.Remove(st);
                        context.SaveChanges();
                    }
                    Console.WriteLine($"Student {response} removed");
                    if (!context.Students.Any()){}
                    else
                        ReadStudentsFromDB(context);

                }
            }
        }

        public static void Update()
        {
            CheckForDatabase();
            do
            {
                Console.Write("Would you like to update a student or an organization phone number? ");
                var response = Console.ReadLine();

                switch (response)
                {
                    case "student":
                    UpdateStudentPhoneNumber();
                    return;
                    case "organization":
                    UpdateOrganizationPhoneNumber();
                    return;
                    default:
                    Console.WriteLine("Please enter student or organization");
                    break;
                }
                
            } while (true);
            
        }
        // Update Student Phone #
        static void UpdateStudentPhoneNumber()
        {
            using (var context = new AppDbContext())
            {
                var student = context.Students;
                if (!student.Any())
                {
                    Console.WriteLine("No students in the database\n");
                }
                else
                {
                    ReadStudentsFromDB(context);
                    Console.Write("\nEnter the ID of the student's phone # you want to update: ");
                    var studentToUpdate = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter the new phone #: ");
                    var newPhoneNumber = Console.ReadLine();

                    foreach (var s in student.Where(id => id.StudentID == studentToUpdate))
                    {
                        s.PhoneNumber = newPhoneNumber;
                    }
                    context.SaveChanges();
                    Console.WriteLine($"Phone recored has been updated");
                }

            }
        }

        static void UpdateOrganizationPhoneNumber()
        {
            using (var context = new AppDbContext())
            {
                var organization = context.Projects.Include(c => c.Client).ThenInclude(o => o.Organization);

                if (!organization.Any())
                {
                    Console.WriteLine("No records in the database to update\n");
                }
                else
                {
                    ReadOrganizationFromDB(context);
                    Console.WriteLine();
                    Console.Write("\nEnter the ID of the organization's phone # you want to update: ");
                    var organizationToUpdate = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter the new phone #: ");
                    var newPhoneNumber = Console.ReadLine();

                    foreach (var o in organization.Where(id => id.Client.OrganizationID == organizationToUpdate))
                    {
                        o.Client.Organization.PhoneNumber = newPhoneNumber;
                    }

                    context.SaveChanges();
                    Console.WriteLine($"Phone recored has been updated");
                }

            }
        }

        static void ReadOrganizationFromDB(AppDbContext db)
        {
            var organization = db.Projects.Include(c => c.Client).ThenInclude(o => o.Organization).AsNoTracking();

            if (!organization.Any())
            {
                Console.WriteLine("No records in the database\n");
            }
            else
            {
                foreach (var o in organization)
                {
                    Console.WriteLine();
                    Console.Write(o.Client.Organization);
                }
            }
        }

        public static void Search()
        {
            CheckForDatabase();
            using (var db = new AppDbContext())
            {
                do
                {
                    Console.Write("Search for a student or an organization? ");
                    var response = Console.ReadLine();

                    switch (response)
                    {
                        case "student":
                        SearchForStudentRecord();
                        return;
                        case "organization":
                        SearchOrganizationRecord();
                        return;
                        default:
                        Console.WriteLine("Please enter student or organization");
                        break;
                    }
                    
                } while (true);
            }
        }

        static void SearchForStudentRecord()
        {
            Console.Write("Please enter the first name of the student you would like to search for: ");
            var nameofStudent = Console.ReadLine();

            using (var db = new AppDbContext())
            {
                var student = db.Students;
                var studentFiltered = student.Where(s => s.FirstName == nameofStudent).AsNoTracking();
                Console.WriteLine();

                if (studentFiltered.Count() != 0)
                {
                    foreach (var s in studentFiltered)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    Console.WriteLine("Student not found.\n");
                }
            }
        }

        static void SearchOrganizationRecord()
        {
            Console.Write("Please enter the name of the organization you would like to search for: ");
            var nameofOrganization = Console.ReadLine();

            using (var db = new AppDbContext())
            {

                var organization = db.Projects.Include(c => c.Client).ThenInclude(o => o.Organization).AsNoTracking();
                var oraganizationFiltered = organization.Where(o => o.Client.Organization.Name == nameofOrganization);
                Console.WriteLine();

                if (oraganizationFiltered.Count() != 0)
                {
                    foreach (var o in organization)
                    {
                        Console.WriteLine(o.Client.Organization);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Organization not found.\n");
                }


            }
        }

        public static void SortRecords()
        {
            CheckForDatabase();
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Students sorted by Last Name in ascending order\n");
                var student = db.Students;
                var studentSorted = student.OrderBy(s => s.LastName);
                foreach (var s in studentSorted)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public static void RecordsGroupBy()
        {
            CheckForDatabase();
            using (var db = new AppDbContext())
            {
                Console.WriteLine("Students grouped by Table #");
                var students = db.Students.AsNoTracking();
                var studentsGrouped = students.GroupBy(se => se.TableNumber);
                Console.WriteLine();

                foreach (var sg in studentsGrouped)
                {
                    Console.WriteLine($"Table Number: {sg.Key}");
                    foreach (var s in sg)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }

                
            }
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

        public static void OneShotCommands(string[] args)
        {
            foreach (var item in args)
                {
                    switch (item)
                    {
                        case "create" : 
                            AddStudents();
                            break;
                        case "read" :
                            using (var context = new AppDbContext())
                            {
                                ReadStudentsFromDB(context);
                            }
                            break;
                        case "update" :
                            Update();
                            break;
                        case "delete" :
                            DeleteStudent();
                            break;
                        case "project" :
                            ReadProjectDetails();
                            break;
                        case "search":
                            Search();
                            break;
                        case "sort":
                            SortRecords();
                            break;
                        case "group":
                            RecordsGroupBy();
                            break;
                        case "-help" :
                            HelpMe();
                            break;
                        default:
                            Console.Write("-----Command unknown------\n");
                            HelpMe();
                            break;
                    }
                        
                }
        }
    }
}