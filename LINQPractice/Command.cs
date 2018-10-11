using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LINQPractice.Models;

namespace LINQPractice
{
    public class Command
    {
        public static void SeedDatabase()
        {
            var students = new List<Student>
            {
                new Student { FirstName = "John", LastName = "Cunningham", ClassRank = ClassRank.Senior, Email = "john@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Mara", LastName = "Kinoff", ClassRank = ClassRank.Senior, Email = "mara@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Matthew", LastName = "Matthews", ClassRank = ClassRank.Senior, Email = "michael@wtamu.edu", TableNumber = 2},
                new Student { FirstName = "Laith", LastName = "Alfaloujeh", ClassRank = ClassRank.Senior, Email = "laith@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Mekkala", LastName = "Bourapa", ClassRank = ClassRank.Senior, Email = "mekkala@wtamu.edu", TableNumber = 1},
                new Student { FirstName = "Charles", LastName = "Coufal", ClassRank = ClassRank.Senior, Email = "Charles@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Michael", LastName = "Hayes", ClassRank = ClassRank.Senior, Email = "Michael@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Aaron", LastName = "Hebert", ClassRank = ClassRank.Senior, Email = "Aaron@wtamu.edu", TableNumber = 4},
                new Student { FirstName = "Yi", LastName = "Ji", ClassRank = ClassRank.Senior, Email = "YiFu@wtamu.edu", TableNumber = 3},
                new Student { FirstName = "Todd", LastName="Kile", ClassRank=ClassRank.Junior, Email="Todd@email.com", TableNumber =  4},
                new Student { FirstName = "Cesareo", LastName="Lona", ClassRank=ClassRank.Senior, Email="Cesareo@wtamu.edu", TableNumber =  3},
                new Student { FirstName = "Mason", LastName="McCollum", ClassRank=ClassRank.Junior, Email="Mason@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="McDonald", ClassRank=ClassRank.Junior, Email="Alexander@email.com", TableNumber =  1},
                new Student { FirstName = "Phelps", LastName="Merrell", ClassRank=ClassRank.Junior, Email="Phelps@email.com", TableNumber =  4},
                new Student { FirstName = "Quan", LastName="Nguyen", ClassRank=ClassRank.Senior, Email="Quan@email.com", TableNumber =  1},
                new Student { FirstName = "Alexander", LastName="Roder", ClassRank=ClassRank.Senior, Email="Alexander@email.com", TableNumber =  2},
                new Student { FirstName = "Amy", LastName="Saysouriyosack", ClassRank=ClassRank.Senior, Email="amy@wtamu.com", TableNumber =  3},
                new Student { FirstName = "Claudia", LastName="Silva", ClassRank=ClassRank.Junior, Email="Claudia@email.com", TableNumber =  3},
                new Student { FirstName = "Vanessa", LastName="Valenzuela", ClassRank=ClassRank.Senior, Email="Gabriela@email.com", TableNumber =  4},
                new Student { FirstName = "Kayla", LastName="Washington", ClassRank=ClassRank.Sophomore, Email="Kayla@email.com", TableNumber =  1},
                new Student { FirstName = "Matthew", LastName="Webb", ClassRank=ClassRank.Junior, Email="Matthew@email.com", TableNumber =  2},

                new Student { FirstName = "Cory", LastName="Williams", ClassRank=ClassRank.Junior, Email="Cory@email.com", TableNumber =  1},
                new Student { FirstName = "Catherine", LastName="McGovern", ClassRank=ClassRank.Senior, Email="Catherine@email.com", TableNumber =  1}
            };

            using (var db = new AppDbContext())
            {
                //db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                
                if(!db.Students.Any())
                {
                    db.AddRange(students);
                    db.SaveChanges();
                }
                else
                {
                    foreach (var s in db.Students)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }

       
        // students who are not seniors
        public static void StudentsNotSeniorsQuerySyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students.ToList();
                var studentsNotSenior = from s in students
                                            where s.ClassRank != ClassRank.Senior
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
           
        }
        public static void StudentsNotSeniorsMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.Where(s => s.ClassRank != ClassRank.Senior);

                PrintToConsole(studentsNotSenior);

            }
            
        }

        //students whose first names begin with letters 'M' or lower
        public static void StudentsFirstNameMQuerySyntax()
        {
             using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = from s in students
                                where s.FirstName[0] >= 'M'
                                select s;

                PrintToConsole(studentsM);
            }
        }
        public static void StudentsFirstNameMMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = students.Where(f => f.FirstName[0] >= 'M');

                PrintToConsole(studentsM);
            }
        }

        // students whose first names begin with letters 'L' or lower
        public static void StudentsFirstNameLQuerySyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsM = from s in students
                                where s.FirstName[0] >= 'M'
                                select s;

                PrintToConsole(studentsM);
            }
        }
        public static void StudentsFirstNameLMethodSyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsL = students.Where(f => f.FirstName[0] <= 'L');

                PrintToConsole(studentsL);
                
            }
        }

        // Connect to the database and show all students who have taken CIDM3350 previously (hint: maybe you need to refactor
        public static void StudentTakenCIDM3350querysyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsTaken3315 = from s in students
                                        where s.ClassRank == ClassRank.Senior
                                        select s;

                PrintToConsole(studentsTaken3315);
                
            }
        }
        
        //Connect to the database and show all students who have taken CIDM3350 previously.

        public static void StudentTakenCIDM3350methodsyntax()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsTaken3315 = students.Where(s => s.ClassRank == ClassRank.Senior);

                PrintToConsole(studentsTaken3315);
            }
        }


        //Connect to the database and find a student named "John" and print that record to the screen
        public static void StudentNamedJohnMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedJohn = students.Where(s => s.FirstName == "John");

                PrintToConsole(studetnsNamedJohn);
            }
        }

        public static void StudentNamedJohnQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedJohn = from s in students
                                            where s.FirstName == "John"
                                            select s;

                PrintToConsole(studetnsNamedJohn);
            } 
        }

        // 2. Connect to the database and find a student named "Alexander" and print that record to the screen

        public static void StudentNamedAlexanderMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedAlexander = students.Where(s => s.FirstName == "Alexander");

                PrintToConsole(studetnsNamedAlexander);
            }
        }

        public static void StudentNamedAlexanderQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studetnsNamedAlexander = from s in students
                                                where s.FirstName == "Alexander"
                                                select s;

                PrintToConsole(studetnsNamedAlexander);
            } 
        }

        // 3. Connect to the database and find a student who has the shortest first name and print that record to the screen

        //names.Min(y=>y.Length);
        public static void StudentShortestFNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var minLength = students.Min(s => s.FirstName.Length);
                var studentsShortestFName = students.Where(f => f.FirstName.Length == minLength);
                

                PrintToConsole(studentsShortestFName);

            }
        }

        public static void StudentShortestFNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsFNameCount = from s in students
                                    orderby s.FirstName.Length
                                    select s;
                Console.WriteLine(studentsFNameCount.First());
            
            }

        }

        // 4. Connect to the database and find a student who has the shortest last name and print that record to the screen
        public static void StudentShortestLNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var minLength = students.Min(s => s.LastName.Length);
                var studentsShortestFName = students.Where(f => f.FirstName.Length == minLength);
                
                PrintToConsole(studentsShortestFName);

            }
        }

        public static void StudentShortestLNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsFNameCount= from s in students
                                            where s.FirstName.Length < 4
                                            select s;
                PrintToConsole(studentsFNameCount);
            }
        }

        // 5.  Connect to the database and find a student who has the shortest last name but also has the longest first name and print that record to the screen

        public static void StudentShortestLNameLongestFNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                // TODO:

            }
        }
        
        public static void StudentShortestLNameLongestFNameQuery()
        {  
            // TODO:
        }

        // Connect to the database and show all students sorted by first name

        public static void SortByFirstNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.OrderBy(f => f.FirstName);
                
                PrintToConsole(studentsNotSenior);  

            }

        }

        public static void SortByFirstNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.FirstName ascending
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // 2. Connect to the database and show all students sorted by last name descending

        public static void SortByLastNameMethod()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = students.OrderByDescending(f => f.LastName);
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        public static void SortByLastNameQuery()
        {
            using (var db = new AppDbContext())
            {
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.LastName descending
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // 3. Connect to the database and show all students sorted by rank (Freshman, Sophomore, Junior, Senior, 

        public static void SortByRankMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var rankSort = students.OrderBy(r => r.ClassRank);

                PrintToConsole(rankSort);
            }
        }

        public static void SortByRankQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var studentsNotSenior = from s in students
                                            orderby s.ClassRank
                                            select s;
                
                PrintToConsole(studentsNotSenior);  

            }
        }

        // Connect to the database and show all students Grouped by class rank

        public static void GroupByClassRankMethod()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = students.GroupBy(g => g.ClassRank);
                
                foreach (var c in classRank)
                {
                    Console.WriteLine("--------Grouped by class rank----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 

            }
        }

        public static void GroupByClassRankQuery()
        {
            using (var db = new AppDbContext())
            { 
                var students = db.Students;
                var classRank = from student in students
                                group student by student.ClassRank;

                foreach (var c in classRank)
                {
                    Console.WriteLine("--------Grouped by class rank----------\n");
                    foreach (var s in c)
                    {
                        Console.WriteLine(s);
                    }
                } 

            }
            
        }

        // 2. Connect to the database and show all students Grouped by class rank and sorted by last name

        public static void GroupByRankSortByLNameMethod()
        {

        }

        public static void GroupByRankSortByLNameQuery()
        {

        }

        // 3. Connect to the database and show all students Grouped by the first letter of their last name and sorted by first name

        public static void GroupByFLetterLnameSortFNameMethod()
        {

        }

        public static void GroupByFLetterLnameSortFNameQuery()
        {

        }

         // print to console
        private static void PrintToConsole(IEnumerable<object> students)
        {
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
        }


    }
}